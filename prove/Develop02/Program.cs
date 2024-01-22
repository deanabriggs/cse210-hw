using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
    
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("  1. Write");
            Console.WriteLine("  2. Display");
            Console.WriteLine("  3. Load");
            Console.WriteLine("  4. Save");
            Console.WriteLine("  5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();
            
            PromptGenerator p = new PromptGenerator();
            Journal j = new Journal();


            if (userChoice == "1")
            {
                string prompt = p.GetRandomPrompt();
                string entry = Console.ReadLine();
            };

            if (userChoice == "2")
            {
                j.DisplayAll();
            }

            if (userChoice == "3")
            {
                j.LoadFromFile();
            }

            if (userChoice == "4")
            {
                Console.WriteLine("");
            }
        }
    } 
}