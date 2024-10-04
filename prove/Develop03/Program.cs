using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a scripture (example: John 3:16)
        Scripture scripture = new Scripture(new Reference("John", 3, 16), 
            "For God so loved the world that he gave his one and only Son, " +
            "that whoever believes in him shall not perish but have eternal life.");

        // Main loop
        while (true)
        {
            Console.Clear(); // Clear the console screen
            scripture.Display(); // Show the current state of the scripture

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; // Exit the loop and end the program
            }

            // Hide random words in the scripture
            scripture.HideRandomWords();

            // End when all words are hidden
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nAll words are hidden! Program will now exit.");
                break;
            }
        }
    }
}
