using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void ReadFromFile(string filename)
{
    _entries.Clear();

    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        string[] parts = line.Split("|", 3);

        string date = parts[0];
        string prompt = parts[1];
        string response = parts[2];

        JournalEntry entry = new JournalEntry(date, prompt, response);

        AddEntry(entry);
    }
}
}
 