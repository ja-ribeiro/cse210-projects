using System;
using System.Threading;

//essa classe vai conter tudo que e comum as tres atividades

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.Write("\nHow long, in second, would you like for your session?:");
        _duration = int.Parse(Console.ReadLine());

                Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGood job!!");
        ShowSpinner(2);

        Console.WriteLine("\nYou completed the activity for " + _duration + " seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime futureTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }

        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }

        Console.WriteLine();
    
    }
}