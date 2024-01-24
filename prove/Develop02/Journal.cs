using System;
using System.Threading.Tasks.Dataflow;
using System.IO;
using System.Net.Mail;

// create the class and make it public
public class Journal
{
    // establish Entry list as a variable - initiating a new list item at the same time
    public List<Entry> _entries = new List<Entry>();

    // establish the functions of the Journal class
    public void AddEntry(Entry newEntry)  //dataType followed by the parameter
    {
        _entries.Add(newEntry);   
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(List<Entry> entries)
    {
        string filename = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            Console.WriteLine("Saving to file...");
            
            foreach (Entry e in entries)
            {
                outputFile.WriteLine($"{e._date} | {e._promptText} | {e._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Entry> entries = new List<Entry>();
        string filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);      
        
        Entry newEntry = new Entry();        
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            newEntry._date = DateTime.Parse(parts[0]);
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            entries.Add(newEntry);
        }
        Console.WriteLine("File loaded.");
    }

}