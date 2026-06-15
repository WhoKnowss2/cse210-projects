using System;
using System.Collections.Generic;

public class ReflectionActivity : BaseActivity
{
    public ReflectionActivity(string description)
        : base("Reflection Activity", description)
    {
    }

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void RunActivity()
    {
        DisplayStartingMessage();

        DisplayGetReady();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown();

        Console.Clear();
        
        
        int questionCount = GetDuration() / 15;

        List<string> availableQuestions = new List<string>(_questions);

        for (int i = 0; i < questionCount && availableQuestions.Count > 0; i++)
        {
            int index = random.Next(availableQuestions.Count);

            Console.Write($"> {availableQuestions[index]} ");
            ShowSpinner(15);
            Console.WriteLine();

            availableQuestions.RemoveAt(index);
        }
        
        DisplayEndingMessage();
    }
}
