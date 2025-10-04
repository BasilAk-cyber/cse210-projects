// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // STEP 1: Create a reference
        Reference reference = new Reference("John", 3, 16);
        
        // STEP 2: Create the scripture text
        string text = "For God so loved the world that he gave his only begotten Son";
        
        // STEP 3: Create a Scripture object
        Scripture scripture = new Scripture(reference, text);
        
        // STEP 4: Main game loop
        while (true)
        {
            // Clear the screen
            Console.Clear();
            
            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();  // Blank line
            
            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden! Great job!");
                break;  // Exit the program
            }
            
            // Ask the user what to do
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            
            // Check if user wants to quit
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;  // Exit the program
            }
            
            // Hide 3 random words
            scripture.HideRandomWords(3);
        }
    }
}