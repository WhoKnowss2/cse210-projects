// Scripture Memorizer
//
// This program helps users memorize a scripture by hiding a few words at a time.
// Press Enter to hide 3 more words, or type "quit" to exit.
//
// Exceeds core requirements by:
// - Presenting a menu to choose from 3 scriptures
// - Only hiding words that are not already hidden (stretch challenge from the assignment)
// - Stripping punctuation from hidden words so underscore count matches letter count only

using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture(new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Scripture scripture2 = new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Scripture scripture3 = new Scripture(new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy.");

        // Show menu
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. 2 Nephi 2:25");
        Console.WriteLine("4. Quit");
        Console.Write("Enter a number: ");
        string choice = Console.ReadLine();

        if (choice == "4")
        {
            return;
        }

        Scripture scripture;
        if (choice == "1")
            scripture = scripture1;
        else if (choice == "2")
            scripture = scripture2;
        else if (choice == "3")
            scripture = scripture3;
        else
        {
            Console.WriteLine("Invalid choice, defaulting to John 3:16.");
            scripture = scripture1;
        }

        // Game loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job!");
                break;
            }

            Console.Write("Press Enter to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
