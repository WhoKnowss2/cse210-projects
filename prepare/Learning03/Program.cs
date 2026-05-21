using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction 1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Fraction 2
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Fraction 3
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Fraction 4
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Loop running 20 random times
        Fraction fraction = new Fraction();   
        Random random = new Random();
        for (int count = 1; count <= 20; count++)
        {
            int numerator = random.Next(1, 11);
            int denominator = random.Next(1, 11);

            fraction.SetTop(numerator);
            fraction.SetBottom(denominator);

            Console.WriteLine($"Fraction {count}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }

    }
}
