using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new();
        Console.WriteLine(f1.GeString());
        Console.WriteLine(f1.GetDecimal());

        Fraction f2 = new(5);
        Console.WriteLine(f2.GeString());
        Console.WriteLine(f2.GetDecimal());

        Fraction f3 = new(2, 4);
        Console.WriteLine(f3.GeString());
        Console.WriteLine(f3.GetDecimal());

        Fraction f4 = new(1 , 3);
        Console.WriteLine(f4.GeString());
        Console.WriteLine(f4.GetDecimal());

    }
}