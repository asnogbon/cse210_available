using System;
using System.Diagnostics.Metrics;

class Program
{
    public static object Percentage { get; private set; }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your Grade Percentage? ");
        string Grade = Console.ReadLine();
        int number = int.Parse(Grade);

        string answer = "";
        string sign = "";

        if (number >= 90)
        {
            answer = "A";
        }
        else if (number >= 80)
        {
            answer = "B";
        }
        else if (number >= 70)
        {
            answer = "C";
        }
        else if (number >= 60)
        {
            answer = "D";
        }
        else
        {
            answer = "F";
        }
       


        int lastdigit = (number % 10);

        if (number >= 94 && number < 60)
        {
            Console.WriteLine($"Your grade is: {answer}");
        }
        else
        {
            if (lastdigit >= 7)
            {
                sign = "+";
            }
            else 
            {
                sign = "-";
            }
            Console.WriteLine($"Your grade is: {answer}{sign}");
        }


        if (number >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}