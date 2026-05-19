using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private Random _rand = new Random();

    // Stores journal prompts for random selection
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day today?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If today had a theme song, what would it be?",
        "If you had one thing you could do over today, what would it be?",
        "What is something difficult you overcame recently?",
        "What is something you learned today?",
        "What fictional character do you relate to today?",
        "Who made a positive impact on your day and why?",
        "What are three things you are grateful for right now?",
        "What is one goal you want to accomplish this week?",
        "If you could improve one thing about today, what would it be?",
        "Describe a moment today that made you smile.",
        "If you could relive one moment from today, which would it be?",
        "What is something you are looking forward to?",
        "What personal strength did you use today?"
    };

    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }
}