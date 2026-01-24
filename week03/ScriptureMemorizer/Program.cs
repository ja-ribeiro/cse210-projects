using System;
using System.Collections.Generic;

/// EXCEEDING REQUIREMENTS: I added a library of scriptures, and it choose scripture at ramdom


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("Press ENTER to start");
        Console.ReadLine();

        // store scripture = library
        List<Scripture> scriptureLibrary = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            ),
            new Scripture(
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            ),
            new Scripture(
                new Reference("Matthew", 5, 9),
                "Blessed are the peacemakers for they shall be called the children of God"
            )
        };

        Random random = new Random();

        // it will choose ramdom scriptures in the library
        Scripture scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nCongratulations! You memorized one more scripture!.");
                break;
            }
        }
    }
}
