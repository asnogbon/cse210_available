using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the magic number? ");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        
        string response = "yes";

        while (response == "yes")
        {

            int guessed = -3;
            while (guessed != number)
            {
                Console.WriteLine("What is your guess? ");
                guessed = int.Parse(Console.ReadLine());

                if (guessed < number)
                {
                    Console.WriteLine("higer"); break;
                }
                else if (guessed >= number)
                {
                    Console.WriteLine("lower"); break;
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                }
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine().ToLower();
        }

    }
}