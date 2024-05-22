using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();

        frac1.SetTop();
        frac1.SetBottom();

        System.Console.WriteLine(frac1.GetTop());
        System.Console.WriteLine(frac1.GetBottom());

        System.Console.WriteLine(frac1.GetFractionString());
        frac1.GetDecimalValue();


    }
}