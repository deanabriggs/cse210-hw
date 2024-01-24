using System;
using System.Collections.Generic;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Journal myJournal = new Journal();

        string userChoice = "";
        while (userChoice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine(" 1. Write");
            Console.WriteLine(" 2. Display");
            Console.WriteLine(" 3. Load");
            Console.WriteLine(" 4. Save");
            Console.WriteLine(" 5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            
            Console.WriteLine(); // create a line space

            if (userChoice == "1")  // Create a new prompt with date and Add a journal entry
            {
                // Get the current Date and save to a variable (found using google Bard)
                DateTime keepDate = DateTime.Today;

                // Generate a Random Prompt and save to a variable
                PromptGenerator prompt = new PromptGenerator();
                string keepPrompt = (prompt.GetRandomPrompt());
                Console.WriteLine(keepPrompt);
                Console.Write("> ");

                // Read the line for a text response and save to a variable
                string keepEntry = Console.ReadLine();

                // Use the AddEntry from the Journal to add the values to the Journal
                Entry newEntry = new Entry();
                
                myJournal.AddEntry(newEntry);
                newEntry._date = keepDate;
                newEntry._promptText = keepPrompt;
                newEntry._entryText = keepEntry;
            }

            if (userChoice == "2")  // Display All Entries (the journal)
            {
                myJournal.DisplayAll();
            }

            if (userChoice == "3")  // Load Journal from file
            {
                myJournal.LoadFromFile();
            }

            if (userChoice == "4")  // Save Journal to file
            {
                myJournal.SaveToFile(myJournal._entries);
            }
        }
    } 
}