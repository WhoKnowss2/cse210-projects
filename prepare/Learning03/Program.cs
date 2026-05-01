using System;

class Program
{
    static void Main(string[] args)
    {
        // Setting playAgain
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Getting random number
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            // Counting guesses
            int guess = -1;
            int guessCount = 0;

            // Guessing loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {guessCount} guesses.");
                }
            }
            // Check if user wants to play again
            Console.Write("Play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
        }
    }
}