using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squared = SquareNumber(favoriteNumber);

        DisplayResult(name, squared, birthYear);
    }

     // Welcome the user
     static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

     // Ask for their name & gather input
     static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Ask for their favorite number & gather input
    static int PromptUserNumber()
    {
        while (true)
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }
    }

    // Ask for their birth year & gather input
    static void PromptUserBirthYear(out int birthYear)
    {
        while (true)
        {
            Console.Write("Please enter the year you were born: ");
            string input = Console.ReadLine();

            try
            {
                birthYear = int.Parse(input);
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid year. Please try again.");
            }
        }
    }

    // Process their favorite number in to squared
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Display the results
    static void DisplayResult(string name, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");

        int currentYear = DateTime.Now.Year;
        int ageThisYear = currentYear - birthYear;

        Console.WriteLine($"{name}, you will turn {ageThisYear} this year.");
    }

}