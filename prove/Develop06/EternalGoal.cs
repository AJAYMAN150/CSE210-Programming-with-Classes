// EternalGoal.cs
public class EternalGoal : Goal
{
    private int _incrementPoints;

    public EternalGoal(string name, string description, int incrementPoints)
        : base(name, description)
    {
        _incrementPoints = incrementPoints;
    }

    public override void RecordProgress()
    {
        _points += _incrementPoints;
        Console.WriteLine($"Progress recorded for {Name}. You earned {_incrementPoints} points.");
    }

    public override bool IsComplete() => false; // Eternal goals never complete

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"{Name} (Eternal) - Total Points: {Points}");
    }
}
