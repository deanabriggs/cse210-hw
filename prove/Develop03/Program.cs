using System;
using System.Security;
class Program
{
    static void Main(string[] args)
    {
        // Creates new objects and Provides the reference and verse        
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Reference myRef = new Reference("Proverbs", 3, 5, 6);

        // Builds the scripture object
        Scripture myScripture = new Scripture(myRef, verseText);

        // Determines how many words will be hidden at a time
        myScripture.HideRandomWords(3);

        string quit = "";
        do 
        {  
            // Clears the console and displays the message
            Console.Clear();
            myScripture.GetDisplayText();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();  // reads if user quit or hit enter
            bool complete = myScripture.IsCompletelyHidden();

            if (complete == true)
            {
                break;
            }
        } while (quit != "quit");
    }
}