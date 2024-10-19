using System;

public class ListingActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Who are some the people that you truly appreciate?",
        "What personal strengths do you have?",
        "Who are people some that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void PerformListing()
    {
        StartActivity();

        int duration = GetDuration();
        Random random = new Random();

        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        Pause(3);
        Console.WriteLine("Start listing your items:");

        DateTime startTime = DateTime.Now;
        int itemCount = 0;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        EndActivity();
    }
}
