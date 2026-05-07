using System;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num = 1;
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }
        while (num != 0);

        int sum = 0; 
        foreach (int word in numbers)
        {
            
            sum += word; 
            
        }
        Console.WriteLine($"The sum is: {sum} ");
        
        int count = (numbers.Count);
        int ave = (sum / count);
        Console.WriteLine($"The average is:{ave} ");

        int high = 0;
        foreach (int word in numbers)
        {
            if (word > high) 
            {  
                high = word;
            }
            

        }
        Console.WriteLine($"The largest number is: {high} ");

        int smallest = int.MaxValue;
        
        foreach (int nums in numbers)
        {
            if (nums > 0 && nums < smallest)
            {
                smallest = nums;
                
                
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest} ");
        var sorted = numbers.OrderBy(n => n);
        foreach (int n in sorted)
        {
            Console.WriteLine($"The sorted list is:{n} ");
        }

            

    }
}