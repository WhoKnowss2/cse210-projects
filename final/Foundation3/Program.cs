using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Lecture events
        Address lectureAddress1 = new Address(
            "100 University Avenue",
            "Provo",
            "Utah",
            "USA");

        Event lecture1 = new Lecture(
            "The Future of Technology",
            "A discussion about emerging technology and innovation.",
            "October 10, 2026",
            "7:00 PM",
            lectureAddress1,
            "Dr. Maria Chen",
            250);

        Address lectureAddress2 = new Address(
            "50 King Street",
            "Toronto",
            "Ontario",
            "Canada");

        Event lecture2 = new Lecture(
            "Exploring the Oceans",
            "A marine biologist shares discoveries from the deep sea.",
            "November 5, 2026",
            "6:30 PM",
            lectureAddress2,
            "Dr. James Wilson",
            180);

        // Reception events
        Address receptionAddress1 = new Address(
            "25 Garden Lane",
            "London",
            "England",
            "United Kingdom");

        Event reception1 = new Reception(
            "Autumn Art Reception",
            "An evening celebrating local artists and their work.",
            "September 18, 2026",
            "5:30 PM",
            receptionAddress1,
            "rsvp@autumnart.org");

        Address receptionAddress2 = new Address(
            "200 Harbor Drive",
            "Sydney",
            "New South Wales",
            "Australia");

        Event reception2 = new Reception(
            "International Business Reception",
            "A networking reception for international business leaders.",
            "December 2, 2026",
            "7:00 PM",
            receptionAddress2,
            "register@globalbusiness.com");

        // Outdoor gathering events
        Address outdoorAddress1 = new Address(
            "1 Central Park West",
            "New York",
            "New York",
            "USA");

        Event outdoorGathering1 = new OutdoorGathering(
            "Community Picnic",
            "A family-friendly picnic with food, music, and games.",
            "August 15, 2026",
            "11:00 AM",
            outdoorAddress1,
            "Sunny with a high of 78°F.");

        Address outdoorAddress2 = new Address(
            "Champ de Mars",
            "Paris",
            "Île-de-France",
            "France");

        Event outdoorGathering2 = new OutdoorGathering(
            "Music Under the Stars",
            "An outdoor evening featuring live classical music.",
            "July 25, 2026",
            "8:00 PM",
            outdoorAddress2,
            "Clear skies with a light breeze.");

        List<Event> events = new List<Event>
        {
            lecture1,
            lecture2,
            reception1,
            reception2,
            outdoorGathering1,
            outdoorGathering2
        };

        foreach (Event currentEvent in events)
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine(currentEvent.GetStandardDetails());

            Console.WriteLine("\nFULL DETAILS");
            Console.WriteLine(currentEvent.GetFullDetails());

            Console.WriteLine("\nSHORT DESCRIPTION");
            Console.WriteLine(currentEvent.GetShortDescription());

            Console.WriteLine("\n----------------------------------------\n");
        }
    }
}