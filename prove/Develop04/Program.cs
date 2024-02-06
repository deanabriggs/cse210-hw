using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity myActivity = new BreathingActivity();
                myActivity.Run();
            }

            if (userChoice == "2")
            {
                ReflectingActivity myActivity = new ReflectingActivity();
                myActivity.Run();
            }

            if (userChoice == "3")
            {
                ListingActivity myActivity = new ListingActivity();
                myActivity.Run();
            }

        } while (userChoice != "4");
        
              
            
        
    }
}