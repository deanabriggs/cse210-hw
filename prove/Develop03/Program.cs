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
        
        // Determiners variables to quit the program
        string quit;
        
        Console.Write("How many words do you want to hide at a time? ");
        int numHide = int.Parse(Console.ReadLine());

        do 
        {
            // Clears the console and displays the message
            Console.Clear();
            Console.Write(myRef.GetDisplayText()+ " ");
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();  // reads if user quit or hit enter

            // Determines how many words will be hidden at a time
            myScripture.HideRandomWords(numHide);

        } while (quit != "quit" && !myScripture.IsCompletelyHidden());

        Console.Clear();
        Console.Write(myRef.GetDisplayText()+ " ");
        Console.WriteLine(myScripture.GetDisplayText());
        Console.WriteLine();
    }

}