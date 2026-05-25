using System;
using System.Collections.Generic;
// ----------------------------------------------------------------------------------------------------------------
// CREATIVITY & EXCEEDING REQUIREMENTS SHOWCASE:
// 1. Scripture Library: The program stores multiple scriptures (both single and multi-verse)
// and selects one completely random upon launching.
// 2. Stretch Challenge: The Scripture class automatically filters words to only hide those that are still visible
//
//-----------------------------------------------------------------------------------------------------------------
class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Joshua", 1, 9), "Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the LORD thy God is with thee whithersoever thou goest.")
        };

        Random rand = new Random();
        Scripture selectedScripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Excellent work! You have Fully memorized the scripture.");
                break;
            }

            Console.WriteLine("Press Enter to hide words, or type quit to exit:");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }
    }

}