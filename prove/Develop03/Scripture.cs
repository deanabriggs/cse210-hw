using System;
using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
public class Scripture
{
    // Variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructors
    public Scripture(Reference reference, string text)
    {   
        _reference = reference;
        
        // split string text to populate the Word List
        string[] words = text.Split(' ');   // used ChatGPT for help on split
        foreach (string word in words)      // iterate through all the words in the verse "text"
        {
            Word value = new Word(word);    // Use the Word class to create a new list item (record) with the word from the verse and assign the record a variable "value"
            _words.Add(value);              // Add the new Word record to the _words list
        }
    }

    // Functions

    // Assisted by classmate Edward Schack
    public void HideRandomWords(int numberToHide)
    {
        int listLength = _words.Count();
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int wordIndex = random.Next(0, listLength);
            if(_words[wordIndex].IsHidden() && !IsCompletelyHidden())
            {
                i--;
            }
            _words[wordIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string verse = "";
        for (int i = 0; i < _words.Count; i++)
        {
            string each = _words[i].GetDisplayText();
            verse += each + " ";
        }        
        return verse;
    }

    // Assisted by classmate Edward Schack
    public bool IsCompletelyHidden()                
    {
        bool hidden = false;
        int verseLength = _words.Count();
        int hiddenCount = 0;
        foreach(Word word in _words){
            if(word.GetDisplayText().Contains('_'))
            {
                hiddenCount ++;
            }
        }
        if(verseLength == hiddenCount)
        {
            hidden = true;
        }
        return hidden;
    }

}