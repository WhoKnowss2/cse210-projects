using System;
using System.Collections.Generic;

public class ListingActivity : BaseActivity
{
    public ListingActivity(string description)
        : base("Listing Activity", description)
    {
    }

     private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public void RunActivity()
    {
        DisplayStartingMessage();

        DisplayGetReady();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.Write("You may begin in: ");
        ShowCountdown();

        Console.WriteLine();

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");

        DisplayEndingMessage();
    }
}