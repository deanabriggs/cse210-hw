using System;

class Program
{
    
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult()
        {
            DisplayWelcome();
            Console.WriteLine($"{PromptUserName()}, the square of your number is {SquareNumber(PromptUserNumber())}");
        }

        DisplayResult();

    }

}