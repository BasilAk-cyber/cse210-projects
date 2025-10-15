public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            Console.WriteLine($"\nProgress! You completed '{_name}' and earned {_points} points!");
            
            if (IsComplete())
            {
                Console.WriteLine($"Congratulations! You've finished this goal {_target} times!");
                Console.WriteLine($"Bonus reward: {_bonus} points!");
            }
            else
            {
                int remaining = _target - _amountCompleted;
                Console.WriteLine($"Keep going! {remaining} more time{(remaining > 1 ? "s" : "")} to complete this goal!");
            }
        }
        else
        {
            Console.WriteLine($"\nThis goal is already complete!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        string display = GetDisplayString();
        display += $" -- Currently completed: {_amountCompleted}/{_target}";
        return display;
    }

    public override int GetPoints()
    {
        int points = _points;
        if (IsComplete())
        {
            points += _bonus;
        }
        return points;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}
