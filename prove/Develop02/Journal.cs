using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    // Method to add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    // Method to save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    // Method to load journal from a file
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (var line in lines)
        {
            string[] parts = line.Split('|');
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry entry = new Entry(prompt, response, date);
            _entries.Add(entry);
        }
    }
}
