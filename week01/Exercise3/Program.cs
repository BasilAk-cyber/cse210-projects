using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int number = rnd.Next(1, 11);

        while (true)
        {
            Console.Write("Enter a number? ");
            string userInput = Console.ReadLine();
            int guess = int.Parse(userInput);

            if (guess > number)
            {
                Console.WriteLine("Try guessing lower");
            } else if (guess < number) {
                Console.WriteLine("Try guessing higer");
            } else 
            {
                Console.Write("You guessed right");
                Console.ReadKey();
                break;
            }

        }
    }
}