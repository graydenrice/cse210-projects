using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction a = new Fraction();

        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimalValue());

        Fraction b = new Fraction(6);
        b.SetTop(6);

        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimalValue());

        Fraction c = new Fraction(16, 4);
        c.SetTop(16);
        c.SetBottom(4);
        
        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimalValue());
    
    }
}