// EXCEEDS REQUIREMENTS:
// 1. I added randomized motivational ending messages to make the activities feel more encouraging.
// 2. The Reflection activity uses random, non‑repeating questions so the experience feels more natural and varied.
// 3. I included menu input validation so the program handles invalid choices instead of crashing or continuing incorrectly.


using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Start();
    }
}