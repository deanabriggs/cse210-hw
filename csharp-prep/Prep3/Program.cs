using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string again = "yes";

        do
        {
            Console.WriteLine("Guess the magic number between 1-100");

            //Request the magic number from the user
            //Console.Write("What is the magic number? ");
            //string inputNumber = Console.ReadLine();             
            //int magic = int.Parse(inputNumber);

            //Generate a random number between 1 & 100 as the magic number
            Random randomGenerator = new Random();
            int magic = randomGenerator.Next(1, 100);

            int guess;
            int times = 0;

            do
            {
                Console.Write("What is your guess? ");
                string inputGuess = Console.ReadLine();
                guess = int.Parse(inputGuess);
                times += 1;

                if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }

            } while (guess != magic);

            Console.WriteLine($"You guessed it in {times} tries!");
            
            Console.Write("Do you want to play again? ");
            again = Console.ReadLine();
            Console.WriteLine();  //add a blank line

        } while (again == "yes" || again == "y");

    }
}