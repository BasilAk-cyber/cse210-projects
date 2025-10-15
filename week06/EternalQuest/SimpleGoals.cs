 public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"\nCongratulations! You completed '{_name}' and earned {_points} points!");
        }
        else
        {
            Console.WriteLine($"\nThis goal is already complete!");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString()
    {
        return GetDisplayString();
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}
