using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<BaseGoal> _goals;
    private int _score;

    // Everyone needs encouragement
    private List<string> _encouragementMessages = new List<string>
    {
        "Fantastic work! Keep it up!",
        "You're making great progress!",
        "Every step counts. Well done!",
        "Awesome job! Stay consistent!",
        "Keep going—you've got this!",
        "Excellent work on your goal!",
        "Your hard work is paying off!",
        "Another goal closer to success!",
        "Way to stay committed!",
        "Great job! Keep building momentum!"
    };

    public GoalManager()
    {
        _goals = new List<BaseGoal>();
        _score = 0;
    }

    // Show score progress
    public void DisplayScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // Show list of goals with current status
    private void DisplayGoalsWithStatus()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            BaseGoal goal = _goals[i];
            string status = goal.IsComplete() ? "[X]" : "[ ]";

            if (goal is ChecklistGoal checklist)
            {
                Console.WriteLine($"{i + 1}. {status} {goal.GetName()} ({goal.GetDescription()}) -- Completed {checklist.GetAmountCompleted()}/{checklist.GetTarget()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {status} {goal.GetName()} ({goal.GetDescription()})");
            }
        }
    }

    // Create a goal
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        int choice;
        Console.Write("Which type of goal would you like to create? ");

        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Please enter a number between 1 and 3.");
            Console.Write("Which type of goal would you like to create? ");
        }

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        int points;
        Console.Write("What is the amount of points associated with this goal? ");
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Please enter a valid number: ");
        }

        if (choice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (choice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == 3)
        {
            int targetAmount;
            Console.Write("How many times does this goal need to be accomplished? ");
            while (!int.TryParse(Console.ReadLine(), out targetAmount))
            {
                Console.Write("Please enter a valid number: ");
            }

            int bonusPoints;
            Console.Write("What is the bonus for accomplishing it that many times? ");
            while (!int.TryParse(Console.ReadLine(), out bonusPoints))
            {
                Console.Write("Please enter a valid number: ");
            }

            _goals.Add(new ChecklistGoal(name, description, points, 0, targetAmount, bonusPoints));
        }
    }

    // Show current goals
    public void ListGoals()
    {
        Console.WriteLine("The goals are:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        DisplayGoalsWithStatus();
    }

    // Records completion of goals
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available. Create one first.");
            return;
        }

        Console.WriteLine("Which goal did you accomplish?");
        DisplayGoalsWithStatus();

        int choice;
        Console.Write("Select the goal you accomplished: ");

        while (!int.TryParse(Console.ReadLine(), out choice) ||
               choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine($"Please enter a number between 1 and {_goals.Count}.");
            Console.Write("Select the goal you accomplished: ");
        }

        int pointsEarned = _goals[choice - 1].RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");

        Random random = new Random();
        Console.WriteLine(_encouragementMessages[random.Next(_encouragementMessages.Count)]);

        Console.WriteLine($"You now have {_score} points.");
    }

    // Save goals to a file
    public void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (BaseGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    // Load goals from a saved file
    public void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] values = parts[1].Split(',');

            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(values[0], values[1], int.Parse(values[2]), bool.Parse(values[3])));
            }
            else if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(values[0], values[1], int.Parse(values[2])));
            }
            else if (goalType == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(values[0], values[1], int.Parse(values[2]),
                    int.Parse(values[3]), int.Parse(values[4]), int.Parse(values[5])));
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}
