// GoalManager.cs
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordGoalProgress(string goalName)
    {
        var goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            _totalPoints += goal.Points;
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            goal.DisplayGoalStatus();
        }
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points}");
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            foreach (var line in File.ReadAllLines(filePath))
            {
                var data = line.Split(',');
                // Load specific goal types based on saved data
                // Parsing and loading each goal from file here...
            }
        }
    }
}
