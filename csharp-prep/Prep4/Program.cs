using System;
// Added Collections
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for numbers & end with 0
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Make a list of integers called numbers and assign the list to the variable
        List<int> numbers = new List<int>();

        // Declare another variable to hold the entered number
        int userNumber = -1;

        // Number gathering loop
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum loop
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Average calculation
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Max loop
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Stretch 1
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
        // Stretch 2
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}
