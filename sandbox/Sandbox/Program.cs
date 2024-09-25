using System;

class Program
{
    static void Main(string[] args)
    {
        List<double> x = new();

        double input;
        input = 1;
        while(input != 0)
        {
            Console.Write("Enter something: ");
            string input_str = Console.ReadLine();
            input = double.Parse(input_str);
            x.Add(input);
        }
        Console.WriteLine("Entered Values:");
        int value = 1;
        foreach(int i in x)
        {
            Console.WriteLine($"Value {value}: {i}");
            value++;
        }
    }
}