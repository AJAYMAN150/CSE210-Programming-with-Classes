// Goal.cs
public abstract class Goal
{
    private string _name;
    private string _description;
    protected int _points;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _points = 0;
    }

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;

    // Abstract methods to be overridden in derived classes
    public abstract void RecordProgress();
    public abstract bool IsComplete();

    public virtual void DisplayGoalStatus()
    {
        Console.WriteLine($"{Name} - {Description} - Points: {Points}");
    }
}
