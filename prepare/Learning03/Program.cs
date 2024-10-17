using System;

class Program
{
    static void Main(string[] args)
    {
        // test constructors
        Fraction fraction = new();
        fraction.fraction();
        Console.WriteLine($"{fraction.getFractionString()}");
        fraction.fraction(6);
        Console.WriteLine($"{fraction.getFractionString()}");
        fraction.fraction(6, 7);
        Console.WriteLine($"{fraction.getDecimalValue()}");

        // test getters/setters
        fraction.setTop(5);
        fraction.setBottom(9);
        Console.WriteLine($"{fraction.getFractionString()}");
        Console.WriteLine($"Using getters: {fraction.getTop()}/{fraction.getBottom()}");
        

    }
}