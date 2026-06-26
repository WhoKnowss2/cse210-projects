// EXCEEDS REQUIREMENTS:
// I added input validation for menu choices and for selecting/recording goal types.
// I also added randomized encouragement messages after recording a goal event.

using System;

public class Program
{
public static void Main(string[] args)
{
Menu menu = new Menu();
GoalManager manager = new GoalManager();

    bool running = true;

    while (running)
    {
        Console.Clear();

        manager.DisplayScore();

        Console.WriteLine();

        menu.DisplayMenu();

        int choice = menu.GetChoice();

        if (choice == 1)
        {
            manager.CreateGoal();
        }
        else if (choice == 2)
        {
            manager.ListGoals();
        }
        else if (choice == 3)
        {
            manager.SaveGoals();
        }
        else if (choice == 4)
        {
            manager.LoadGoals();
        }
        else if (choice == 5)
        {
            manager.RecordEvent();
        }
        else if (choice == 6)
        {
            running = false;
        }

        if (running)
        {
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
}
