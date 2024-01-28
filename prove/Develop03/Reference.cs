using System;
public class Reference
{
    // Variables
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;

    // Constructors
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Functions
    public string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}