using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inputPercent = Console.ReadLine();
        int percent = int.Parse(inputPercent);              // Take the user input value and make it a number

        // Assign a letter grade value to the percent given
        string letter;
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the grade should have a "+" or "-"
        int lastDigit = percent % 10;  // returns the last digit of the number
        string sign;
        if(percent >= 97)
        {
            sign = "";
        }
        else if(percent < 60)
        {
            sign = "";
        }
        else if(lastDigit >= 7)
        {
            sign = "+";
        }
        else if(lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Grade: {letter}{sign}");

        // Return a message depending on the percent value
        if (percent >= 70)
        {
            Console.WriteLine("Congradulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass this time, but with more study and practice, you will succeed next time.");
        }

    }
}