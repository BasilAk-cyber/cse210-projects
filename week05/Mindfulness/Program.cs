// I Exceeded requirement my saving entries in Listing Activity to a file

using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Mindfulness Program!");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        

        while (true)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("Please Enter your Choice:");
            string Choice = Console.ReadLine();

            switch (Choice.Trim())
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    Console.WriteLine("\nThank you for using the Mindfulness Program!");
                    return;
                default:
                    Console.WriteLine("\nInvalid choice. Please select 1-4.");
                    ShowSpinner(2);
                    Console.Clear();
                    break;
            }
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
            Console.Clear();

            
        }
        

    }


}