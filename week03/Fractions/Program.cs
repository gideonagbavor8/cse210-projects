using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1);
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetFractionValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetFractionValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetFractionValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetFractionValue());
    }
}