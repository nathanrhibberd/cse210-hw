using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction_1 = new Fraction();
        Fraction fraction_2 = new Fraction(5);
        Fraction fraction_3 = new Fraction(3, 4);
        Fraction fraction_4 = new Fraction(1, 3);
        Fraction fraction_5 = new Fraction(12, 7);
        Console.WriteLine(fraction_1.GetFractionString());
        Console.WriteLine(fraction_1.GetDecimalValue());
        Console.WriteLine(fraction_2.GetFractionString());
        Console.WriteLine(fraction_2.GetDecimalValue());
        Console.WriteLine(fraction_3.GetFractionString());
        Console.WriteLine(fraction_3.GetDecimalValue());
        Console.WriteLine(fraction_4.GetFractionString());
        Console.WriteLine(fraction_4.GetDecimalValue());
        Console.WriteLine(fraction_5.GetFractionString());
        Console.WriteLine(fraction_5.GetDecimalValue());
    }
}