// EXCEEDS REQUIREMENTS:
// 1. Added randomized motivational ending messages to enhance user experience.
// 2. Reflection activity uses random, non-repeating questions for higher variety and polish.
// 3. Added menu input validation to handle invalid choices and improve program robustness.


using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Start();
    }
}