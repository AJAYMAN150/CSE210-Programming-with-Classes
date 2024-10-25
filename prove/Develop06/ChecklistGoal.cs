// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _incrementPoints;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int targetCount, int incrementPoints, int bonusPoints)
        : base(name, description)
    {
        _targetCount = targetCount;
        _incrementPoints = incrementPoints;
        _bonusPoints = bonusPoints;
    }

    public override void RecordProgress()
    {
        _currentCount++;
        _points += _incrementPoints;

        if (_currentCount >= _targetCount)
        {
            _points += _bonusPoints;
            Console.WriteLine($"{Name} completed! Bonus of {_bonusPoints} points awarded.");
        }
        else
        {
            Console.WriteLine($"Progress recorded for {Name}. You earned {_incrementPoints} points.");
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override void DisplayGoalStatus()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} - {Description} - Progress: {_currentCount}/{_targetCount} - Points: {Points}");
    }
}
