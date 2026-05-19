// Exceeding Requirements:
// - Added more than 10 unique journal prompts for greater variety
// - Added a greeting and affirmation
// - Added input validation for menu selections to prevent invalid choices
// - Added basic error handling improvements for a smoother user experience
// - Created a separate PromptGenerator class to organize prompt logic
// - Organized the program into multiple classes with focused responsibilities
// - Added thoughtful and reflective prompts to improve the journaling experience
// - Added confirmation messages after actions such as adding entries
//   and saving journal files to improve user feedback


using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Hello again. Your day matters.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();

            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load From File");
            Console.WriteLine("4. Save To File");
            Console.WriteLine("5. Quit");
            Console.WriteLine();

            bool valid = false;

            while (!valid)
            {
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= 1 && choice <= 5)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 5.");
                }
            }

            if (choice == 1)
            {
                string prompt = generator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("Your response: ");

                string response = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(response))
                {
                    Console.WriteLine("Please enter a response.");
                    response = Console.ReadLine();
                }

                JournalEntry entry = new JournalEntry(
                    DateTime.Now.ToShortDateString(),
                    prompt,
                    response
                );

                journal.AddEntry(entry);

                Console.WriteLine();
                Console.WriteLine("Entry added successfully.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

            else if (choice == 2)
            {
                Console.WriteLine();

                journal.Display();

                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Filename cannot be empty.");
                    Console.Write("Enter filename: ");
                    filename = Console.ReadLine();
                }

                try
                {
                    journal.ReadFromFile(filename);

                    Console.WriteLine();
                    Console.WriteLine("Journal loaded successfully.");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine();
                    Console.WriteLine("File not found.");
                }

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }

            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Filename cannot be empty.");
                    filename = Console.ReadLine();
                }

                journal.SaveToFile(filename);

                Console.WriteLine();
                Console.WriteLine("Journal saved successfully.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}