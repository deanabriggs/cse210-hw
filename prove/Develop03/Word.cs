using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
public class Word
{
    // Variables
    private string _text;
    private bool _isHidden = false;

    // Constructors
    public Word(string text)
    {
        _text = text;
    }

    // Functions
    public void Hide()      // sets the value to hide the word
    {
        _isHidden = true;
    }
    public void Show()      // sets the value to show the word
    {
        _isHidden = false;
    }
    public bool IsHidden()  // returns the hidden status (true or false)
    {
        return _isHidden;   
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            char[] resultArray = new char[_text.Length]; // create a list for each charater in a word (used ChatGPT to assist)
            for (int i = 0; i < _text.Length; i++)        
            {
                if (char.IsLetter(_text[i]))            // determines if the character is a letter first
                {
                    resultArray[i] = '_';
                }
                else
                {
                    resultArray[i] = _text[i];
                }
            }
            return new string(resultArray);
        }
        else
        {
            return _text;
        }
    }
}