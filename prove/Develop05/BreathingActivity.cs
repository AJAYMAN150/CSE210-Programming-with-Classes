using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.")
    {
    }

    public void PerformBreathing()
    {
        StartActivity();

        int duration = GetDuration();
        for (int i = 0; i < duration / 2; i++) // Alternate between 'Breathe in' and 'Breathe out'
        {
            Console.WriteLine("Breathe in...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }

        EndActivity();
    }
}
