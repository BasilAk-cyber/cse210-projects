 public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        
        DisplayWelcome();
        
        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    Console.WriteLine("Thanks for using Eternal Quest! Keep working on your goals!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine("===============================================");
        Console.WriteLine("           ETERNAL QUEST");
        Console.WriteLine("     Level Up Your Life, One Goal at a Time");
        Console.WriteLine("===============================================\n");
    }

    private void DisplayPlayerInfo()
    {
        int level = GetLevel();
        string title = GetTitle(level);
        int pointsToNext = GetPointsToNextLevel();
        
        Console.WriteLine($"\n--------------------------------------------------");
        Console.WriteLine($"You have {_score} points. | Level {level}: {title}");
        if (pointsToNext > 0)
        {
            Console.WriteLine($"Next level in: {pointsToNext} points");
        }
        else
        {
            Console.WriteLine("MAX LEVEL REACHED!");
        }
        Console.WriteLine($"--------------------------------------------------");
    }

    private int GetLevel()
    {
        return (_score / 1000) + 1;
    }

    private string GetTitle(int level)
    {
        return level switch
        {
            1 => "Beginner",
            2 => "Apprentice",
            3 => "Journeyman",
            4 => "Expert",
            5 => "Master",
            >= 6 => "Legend",
            _ => "Beginner"
        };
    }

    private int GetPointsToNextLevel()
    {
        int level = GetLevel();
        if (level >= 6) return 0;
        return (level * 1000) - _score;
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine($"\nGoal '{name}' created successfully!");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet. Create a goal first!");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
        
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goals.Count)
        {
            int oldLevel = GetLevel();
            
            Goal selectedGoal = _goals[choice - 1];
            selectedGoal.RecordEvent();
            
            // Add points based on goal type
            int pointsEarned = selectedGoal.GetPoints();
            _score += pointsEarned;

            int newLevel = GetLevel();
            if (newLevel > oldLevel)
            {
                DisplayLevelUp(newLevel);
            }

            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private void DisplayLevelUp(int newLevel)
    {
        Console.WriteLine("\n===========================================");
        Console.WriteLine("           LEVEL UP!");
        Console.WriteLine("===========================================");
        Console.WriteLine($"  You are now Level {newLevel}: {GetTitle(newLevel)}!");
        Console.WriteLine("  Keep up the amazing work!\n");
    }

    private void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved successfully to {filename}!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(filename);
            
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] goalData = parts[1].Split(',');

                Goal goal = null;

                switch (goalType)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]), bool.Parse(goalData[3]));
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[3]));
                        break;
                    case "ChecklistGoal":
                        goal = new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), 
                                                int.Parse(goalData[3]), int.Parse(goalData[4]), int.Parse(goalData[5]));
                        break;
                }

                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }

            Console.WriteLine($"Goals loaded successfully from {filename}!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}
