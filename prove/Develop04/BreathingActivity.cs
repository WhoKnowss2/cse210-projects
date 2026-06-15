using System;

public class BreathingActivity : BaseActivity
{
    public BreathingActivity(string description)
        : base("Breathing Activity", description)
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        DisplayGetReady();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown();

            Console.Write("Now breathe out... ");
            ShowCountdown();
        }

        DisplayEndingMessage();
    }
}