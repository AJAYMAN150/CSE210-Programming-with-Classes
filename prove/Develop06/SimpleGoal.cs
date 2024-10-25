// SimpleGoal.cs
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description)
    {
        _points = points;
        _isComplete = false;
    }

    public override void RecordProgress()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"{Name} completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"{Name} is already completed.");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override void DisplayGoalStatus()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - Points: {Points}");
    }
}
