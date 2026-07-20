using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 4.8));
        activities.Add(new Running("10 Nov 2022", 45, 7.5));

        activities.Add(new Cycling("05 Nov 2022", 60, 20.0));
        activities.Add(new Cycling("12 Nov 2022", 40, 18.5));

        activities.Add(new Swimming("07 Nov 2022", 30, 40));
        activities.Add(new Swimming("14 Nov 2022", 45, 60));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}