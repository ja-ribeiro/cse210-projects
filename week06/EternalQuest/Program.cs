using System;
using System.Collections.Generic;

//EXCEEDING REQUIREMENTS: I added a level system (user level can up every 1000 points). And title  system, based on level

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}