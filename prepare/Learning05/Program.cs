using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square(7, "Purple");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(8, 3, "Orange");
        shapes.Add(rectangle);

        Circle circle = new Circle(4, "Yellow");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}