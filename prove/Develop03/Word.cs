using System;

public class Word
{
    // Variables
    private string _text;
    private bool _isHidden = false;

    // Constructors
    public Word(string text)
    {}

    // Functions
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;   
    }

    public string GetDisplayText()
    {
        return _text;
    }

}