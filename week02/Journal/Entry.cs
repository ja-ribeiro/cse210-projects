using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood;

    public Entry(string date, string promptText, string entryText, string mood)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
    }

    public void Display()
    {
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    // Escape CSV fields correctly
    private string Escape(string text)
    {
        text = text.Replace("\"", "\"\"");
        return $"\"{text}\"";
    }

    public string ToCsvString()
    {
        return $"{Escape(_date)},{Escape(_mood)},{Escape(_promptText)},{Escape(_entryText)}";
    }

    public static Entry FromCsvString(string line)
    {
        string[] parts = ParseCsvLine(line);
        return new Entry(parts[0], parts[2], parts[3], parts[1]);
    }

    private static string[] ParseCsvLine(string line)
    {
        var values = new System.Collections.Generic.List<string>();
        bool inQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                values.Add(current.Replace("\"\"", "\""));
                current = "";
            }
            else
            {
                current += c;
            }
        }

        values.Add(current.Replace("\"\"", "\""));
        return values.ToArray();
    }
}
