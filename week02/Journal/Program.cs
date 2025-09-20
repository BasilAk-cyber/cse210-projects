using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string[] prompts = {
            "What was the best part of your day? ",
            "What did you learn today",
            "Describe a challenge you faced"
        };
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nJournal App Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            Console.Write("Select an option (1-5): ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your Response: ");
                    String response = Console.ReadLine();
                    String date = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(prompt, response, date));
                    break;
                case "2":
                    if (journal.EntryCount() == 0)
                    {
                        Console.WriteLine("No entry in journal");
                    }
                    else
                    {
                        journal.DisplayJournal();
                    }

                    break;
                case "3":
                    Console.Write("Enter a filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case "4":

                    break;
                case "5":
                    return;
                
                default:
                    Console.WriteLine("Invalid option. Please chose 1-5");
                    break;
            }
        }
    }
}