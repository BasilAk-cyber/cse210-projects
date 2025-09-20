using System;
using System.Diagnostics;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Score? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);

        string grade;

        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        int lastDigit = score % 10;

      
        if (lastDigit >= 7)
        {
            grade += "+";
        }
        else if (lastDigit <= 3)
        {
            grade += "-";
        }


        if (grade ==  "A+") {
            grade = "A";
        }



        Console.WriteLine(grade);
    }
}
