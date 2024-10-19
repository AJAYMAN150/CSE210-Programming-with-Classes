using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.PerformBreathing();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.PerformReflection();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.PerformListing();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
