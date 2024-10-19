using System;

public class MindfulnessActivity
{
    private string _activityName;
    private string _description;
    private int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_activityName}: {_description}");
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        Pause(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Well done! You have completed the {_activityName} activity.");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
}
