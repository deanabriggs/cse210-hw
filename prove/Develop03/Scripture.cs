using System;
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
        int hideTimes = 0;
        do
        {
            Random randomNumber = new Random();
            int i = randomNumber.Next(0, _words.Count); // finds a random index number based on the number of words in the list
            _words[i].Hide();                           // use the hide function to change the status (value) of the record
            hideTimes += hideTimes;                     // counts how many times the loop has run

        } while (hideTimes < numberToHide);   
    }

    public string GetDisplayText()
    {
        string verse = "";
        for (int i = 0; i < _words.Count; i++)
        {
            string each = _words[i].GetDisplayText();
            verse += each + " ";
        }
        return $"{_reference} {verse}";
    }

    public bool IsCompletelyHidden()
    {
        bool hid = false;
        int wordsCkd = 0;
        do
        {   
            for (int i = 0; i < _words.Count; i++)
            {
                hid = _words[i].IsHidden();
                wordsCkd += wordsCkd;
            }
        } while (hid == false || wordsCkd < _words.Count);

        if (hid == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}