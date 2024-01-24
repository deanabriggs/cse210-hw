using System;

public class Entry
{
    public DateTime _date;

    public string _promptText;

    public string _entryText;

    public void Display()
    {
        string formatDate = _date.ToString("MM/dd/yyyy");
        Console.WriteLine ($"\nDate: {formatDate} - Prompt: {_promptText}");
        Console.WriteLine (_entryText);
    }
}