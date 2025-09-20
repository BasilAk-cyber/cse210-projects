using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number to add to the list: ");
            string userInput = Console.ReadLine();
            int fiqure = int.Parse(userInput);

            numbers.Add(fiqure);

            Console.WriteLine("Fiqure has been added");

            if (fiqure == 0)
            {
                numbers.Remove(0);
                break;
            }
        }

        int total = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];

        }
        Console.WriteLine($"The total is {total}");

        int largestNum = numbers[0];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNum)
            {
                largestNum = numbers[i];

            }
            
        }
        Console.WriteLine($"The largest number is {largestNum}");

        double average = total / numbers.Count;

        Console.WriteLine($"The average of the list is {average}");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    
}
