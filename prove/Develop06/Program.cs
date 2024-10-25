// Program.cs
using System;

public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();

        // Create some goals
        manager.AddGoal(new SimpleGoal("Complete a Course", "Finish the course for 500 points", 500));
        manager.AddGoal(new EternalGoal("Daily Scripture Study", "Study scriptures each day for 100 points", 100));
        manager.AddGoal(new ChecklistGoal("Temple Visits", "Visit the temple 5 times", 5, 50, 500));
        manager.AddGoal(new ExerciseGoal("Daily Exercise", "Exercise every day to improve health"));

        // Main interaction loop
        while (true)
        {
            Console.WriteLine("\n1. Display Goals\n2. Record Progress\n3. Save Goals\n4. Load Goals\n5. Exit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.DisplayGoals();
            }
            else if (choice == "2")
            {
                Console.Write("Enter goal name to record progress: ");
                string goalName = Console.ReadLine();
                manager.RecordGoalProgress(goalName);
            }
            else if (choice == "3")
            {
                manager.SaveGoals("GoalData.txt");
            }
            else if (choice == "4")
            {
                manager.LoadGoals("GoalData.txt");
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}
