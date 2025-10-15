public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
    }

    public EternalGoal(string name, string description, int points, int timesCompleted)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        Console.WriteLine($"\nGreat work! You completed '{_name}' and earned {_points} points!");
    }

    public override bool IsComplete() => false; // Eternal goals never complete

    public override string GetDetailsString()
    {
        string display = GetDisplayString();
        display += $" - Completed {_timesCompleted} times";
        return display;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points},{_timesCompleted}";
    }
}
