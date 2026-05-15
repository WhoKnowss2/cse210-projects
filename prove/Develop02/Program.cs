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
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Load From File");
            Console.WriteLine("4. Save To File");
            Console.WriteLine("5. Quit");

            // REMOVE the old prompt line here

            bool valid = false;
            while (!valid)
            {
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
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
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                JournalEntry entry = new JournalEntry();
                entry.CreateJournalEntry(DateTime.Now.ToShortDateString(), prompt, response);

                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.ReadFromFile(filename);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}
