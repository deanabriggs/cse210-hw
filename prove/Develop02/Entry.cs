using System;

public class Entry
{
    public DateTime _date;

    public string _promptText;

    public string _entryText;

    public void Display()
    {
        Console.WriteLine ($"\nDate: {_date} \nPrompt: {_promptText}");
        Console.WriteLine (_entryText);
    }
}