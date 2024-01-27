using System;
using System.Reflection.Metadata;
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

    public bool IsCompletelyHidden()
    {
        bool hid = false;
        do
        {   
            for (int i = 0; i < _words.Count; i++)
            {
                hid = _words[i].IsHidden();
                if (hid == false)
                {
                    return false;
                    }
            }
        } while (hid == true);
        return true;
    }

}