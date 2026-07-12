using System;
using System.Linq.Expressions;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
    }
    public void SaveToFile(string file)
    {
        
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
    }
}