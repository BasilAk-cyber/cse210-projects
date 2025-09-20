using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        PromptUserName();
        string name = Console.ReadLine();
        PromptUserNumber();
        int number = int.Parse(Console.ReadLine());
        int squarenum = SquareNumber(number);
        DisplayResult(name, squarenum);

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program");
        }

        static void PromptUserName()
        {
            Console.Write("Please Enter your name: ");
        }

        static void PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Brother {name}, the square of your number is {number}");
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }
    }
}