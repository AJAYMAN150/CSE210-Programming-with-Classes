// ExerciseGoal.cs
public class ExerciseGoal : Goal
{
    private int _streakCount = 0;
    private DateTime _lastExerciseDate;

    public ExerciseGoal(string name, string description) : base(name, description) { }

    public override void RecordProgress()
    {
        _points += 100;

        if ((DateTime.Now - _lastExerciseDate).TotalDays == 1)
        {
            _streakCount++;
            _points += 50 * _streakCount;
        }
        else
        {
            _streakCount = 1;
        }

        _lastExerciseDate = DateTime.Now;
        Console.WriteLine($"{Name} recorded! Streak: {_streakCount}, Points: {Points}");
    }

    public override bool IsComplete() => false;

    public override void DisplayGoalStatus()
    {
        Console.WriteLine($"{Name} - Streak: {_streakCount} days - Total Points: {Points}");
    }
}
