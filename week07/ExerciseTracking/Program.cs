using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Jan 2026", 30, 5.0);
        Cycling cycling = new Cycling("04 Jan 2026", 40, 20.0);
        Swimming swimming = new Swimming("05 Jan 2026", 35, 20);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    
}