using System;

public class Menu
{
    public void Start()
    {
        bool quit = false;

        while (!quit)
        {
            Console.Clear();

            Console.WriteLine("Please choose an option:");
            Console.WriteLine();
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();

                BreathingActivity activity =
                    new BreathingActivity("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                activity.RunActivity();
            }
            else if (choice == "2")
            {
                Console.Clear();

                ReflectionActivity activity =
                    new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                activity.RunActivity();
            }
            else if (choice == "3")
            {
                Console.Clear();
                
                ListingActivity activity =
                    new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                activity.RunActivity();
            }
            else if (choice == "4")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.ReadLine();
            }
        }
    }
}