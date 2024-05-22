using System;

class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    public int GetTop()
    {return _top;}
    public int GetBottom()
    {return _bottom;}
    public void SetTop()
    {
        System.Console.WriteLine("What number do you want to set for the numerator?");
        string input = Console.ReadLine();
        int intInput = int.Parse(input);

        _top = intInput;
    
    }

    public void SetBottom()
    {
        System.Console.WriteLine("What number do you want to set for the denomunator?");
        string input = Console.ReadLine();
        int intInput = int.Parse(input);

        _bottom = intInput;
    
    }
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public void GetDecimalValue()
    {
        double dec = (double)_top / _bottom;
        System.Console.WriteLine(dec);
    }
}