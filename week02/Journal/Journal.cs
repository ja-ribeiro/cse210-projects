using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("\"Date\",\"Mood\",\"Prompt\",\"Entry\"");

            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCsvString());
            }
        }

        Console.WriteLine("Journal saved as CSV.");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);

        for (int i = 1; i < lines.Length; i++)
        {
            Entry entry = Entry.FromCsvString(lines[i]);
            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded from CSV.");
    }
}
