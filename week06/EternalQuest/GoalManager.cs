using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        string input = "";

        while (input != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            input = Console.ReadLine();

            if (input == "1") CreateGoal();
            if (input == "2") ListGoals();
            if (input == "3") RecordEvent();
            if (input == "4") SaveGoals();
            if (input == "5") LoadGoals();
        }
    }

    private void DisplayPlayerInfo()
    {
        int level = _score / 1000 + 1;

        string title = "Beginner";
        if (level >= 3) title = "Disciple";
        if (level >= 5) title = "Eternal Warrior";

        Console.WriteLine($"\nYou have {_score} points");
        Console.WriteLine($"Level: {level} | Title: {title}\n");
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create: ");

        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("Add a short description of it: ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, description, points));

        if (type == "2")
            _goals.Add(new EternalGoal(name, description, points));

        if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine("\nThe goal are:");
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    private void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string type = parts[0];
            string data = parts[1];

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(data, "", 100));

            if (type == "EternalGoal")
                _goals.Add(new EternalGoal(data, "", 100));

            if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(data, "", 100, 5, 500));
        }
    }
}
