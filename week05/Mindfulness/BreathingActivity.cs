using System;

public class BreathingActivity : Activity
{
    // Aqui está CORRETO o uso do base
    public BreathingActivity() 
        : base("Welcome to Breathing Activity!",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(4);

            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}
