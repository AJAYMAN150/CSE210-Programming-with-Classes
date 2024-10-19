using System;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone that needed it.",
        "Think of a time when you did were selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was over?",
        "What is your favorite thing about this experience so far?",
        "What could you learn from this?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void PerformReflection()
    {
        StartActivity();

        int duration = GetDuration();
        Random random = new Random();

        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        Pause(3);

        for (int i = 0; i < duration / 5; i++)
        {
            Console.WriteLine(_questions[random.Next(_questions.Length)]);
            Pause(3);
        }

        EndActivity();
    }
}
