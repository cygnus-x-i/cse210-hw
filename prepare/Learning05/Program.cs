using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new();
        square.SetColor("Green");
        square._side = 5;
        Rectangle rectangle = new();
        rectangle.SetColor("Red");
        rectangle._length = 3;
        rectangle._width = 4;
        Circle circle = new();
        circle.SetColor("Blue");
        circle._radius = 2;

        List<Shape> shapes = new(){square, rectangle, circle};

        foreach(Shape i in shapes)
        {
            Console.WriteLine($"{i.GetColor()}, {i.GetArea()}");
        }
    }
}