
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVE FEATURE:
        // The program contains a library of scriptures and randomly
        // selects one each time it starts, instead of using only one
        // fixed scripture. This gives users different passages to memorize.

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths."
            ),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),

            new Scripture(
                new Reference("Joshua", 1, 9),
                "Have not I commanded thee Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest."
            )
        };

        // Randomly select a scripture from the library
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);

        Scripture selectedScripture = scriptureLibrary[randomIndex];

        // Continue until the user quits or all words are hidden
        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine("SCRIPTURE MEMORIZER");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press ENTER to hide more words or type 'quit' to exit.");

            string userInput = Console.ReadLine() ?? "";

            // Check whether the user wants to quit
            if (userInput.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for practicing!");
                return;
            }

            // Hide three additional random words
            selectedScripture.HideRandomWords(3);
        }

        // Display the final scripture with all words hidden
        Console.Clear();

        Console.WriteLine("SCRIPTURE MEMORIZER");
        Console.WriteLine("-------------------");
        Console.WriteLine();

        Console.WriteLine(selectedScripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Congratulations! You have hidden all the words.");
        Console.WriteLine("You have completed this memorization session!");
    }
}
