using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int numEntered = 0;  // initial value of 0 only works using a "do while" command
        
        do
        {
            Console.Write("Enter number: ");
            string entered = Console.ReadLine();
            numEntered = int.Parse(entered);
            
            if (numEntered != 0)
                numbers.Add(numEntered);  // add number to list

        } while (numEntered != 0);


        // Calculate the sum of the list and identify the max number
        int numSum = 0;
        int numMax = -999999999;
        int numPosMin = 999999999;

        foreach (int number in numbers)
        {    
            // add the numbers of the list together
            numSum += number;  

            // find the max number
            if (numMax < number)
            {
                numMax = number;
            }

            // find the minimum positive number
            if (number > 0)
            {
                if (numPosMin > number)
                {
                    numPosMin = number;
                }
            }
        }

        Console.WriteLine($"The sum is: {numSum}");

        // Calculate the average
        float numAvg = ((float)numSum) / numbers.Count;
        Console.WriteLine($"The average is: {numAvg}");

        // Print the Largest number
        Console.WriteLine($"The largest number is: {numMax}");

        // Print the Smallest Positive number
        Console.WriteLine($"The smallest positive number is: {numPosMin}");

        // Sort and print the list
        numbers.Sort();
        Console.WriteLine("The sored list is:");
        foreach (int sortNum in numbers)
        Console.WriteLine(sortNum);

        Console.WriteLine("");  // blank line

    }
}