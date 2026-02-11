using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?"
    };

    public ListingActivity()
        : base("Welcome to the Listing Activity",
              "This activity will help you reflect ont he good thing in your life by having a list as many positive things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\n" + prompt);

        ShowCountDown(5);

        List<string> items = GetListFromUser();

        _count = items.Count;

        Console.WriteLine("\nYou listed " + _count + " items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }

        return userList;
    }
}
