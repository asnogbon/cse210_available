using System;

class Program
{
    static void Main(string[] args)
    {
        
        string userName = "y";
        int userNumber = 0;

        DisplayMessage();
        DisplayPersonalMessage(userName);
        DisplayPersonalNumber(userNumber);


        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string DisplayPersonalMessage(string userName)
        {
            Console.Write($"Please enter your name: ");
            userName = Console.ReadLine();
            return userName;
        }

        static int DisplayPersonalNumber(int userNumber)
        {
            Console.WriteLine($"Please enter your favorite number: {userNumber}");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
    
}