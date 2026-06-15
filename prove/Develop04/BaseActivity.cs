using System;
using System.Collections.Generic;
using System.Threading;

public class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;

    private List<string> _endingMessages = new List<string>
    {
        "Well done!",
        "Great job!",
        "Excellent work!",
        "You should feel proud of yourself!",
        "Another step toward mindfulness!"
    };

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();        
    }

    public void DisplayEndingMessage()
    {
        Random random = new Random();
        string message = _endingMessages[random.Next(_endingMessages.Count)];

        Console.WriteLine();
        Console.WriteLine(message);
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(5);

        Console.WriteLine();
    }

    public void DisplayGetReady()
    {
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;
        }
    }

    public void ShowCountdown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
}