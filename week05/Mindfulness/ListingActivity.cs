using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider The Following Prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        Console.WriteLine();
        Console.Write("Think about the Prompt. You will begin in... ");
        ShowCountDown(5);

        Console.WriteLine("Start listing items. Press Enter/Return after each item.");
        Console.WriteLine("Your session will end when you have reached your duration.\n");
       

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> items = new List<string>();
        bool previousEmpty = false;


        while (DateTime.Now < endTime)
        {

            Console.Write("> ");

            string input = Console.ReadLine();

            if (input == null) // Handle Ctrl+C or null input
            {
                break;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                if (previousEmpty)
                {
                    // Double Enter detected
                    break;
                }
                previousEmpty = true;
                Console.WriteLine("Keep going! You still have time remaining.");
                continue;
            }

            previousEmpty = false;
            items.Add(input.Trim());



        }
        int count = items.Count();
        Console.WriteLine($"\nYou listed {count} items!");

        SaveItems(items, prompt);


        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayPrompt(string Prompt)
    {
        Console.WriteLine(Prompt);
    }

    private void SaveItems(List<string> items, string prompt)
    {
        string filename = "listing_log.txt";
        try
        {
            using (StreamWriter writer = File.AppendText(filename))
            {
                writer.WriteLine($"[{DateTime.Now}] {prompt}");
                foreach (var item in items)
                {
                    writer.WriteLine($" - {item}");
                }
                writer.WriteLine();
            }
            Console.WriteLine("\nYour items have been saved to listing_log.txt!");
            ShowSpinner(2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving items: {ex.Message}");
        }
    }

}