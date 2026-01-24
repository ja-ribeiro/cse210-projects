using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // store scriptures = library
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

    }
}