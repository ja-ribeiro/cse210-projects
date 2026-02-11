using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() 
        : base("Welcome to Reflecting Activity",
               "This activity help you Reflect on times in your life when you have shown strength.")
    {
        _prompts = new List<string>()
        {
            "Think of a time you helped someone.",
            "Think of a time you were brave."
        };

        _questions = new List<string>()
        {
            "Why was this meaningful?",
            "How did you feel?",
            "What did you learn?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    public void DisplayPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine("\n" + _prompts[index]);
        ShowSpinner(3);
    }

    public void DisplayQuestions()
    {
        Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            int index = rand.Next(_questions.Count);
            Console.WriteLine("> " + _questions[index]);
            ShowSpinner(4);
        }
    }
}
