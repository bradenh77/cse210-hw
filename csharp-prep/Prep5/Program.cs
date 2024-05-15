using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Welcome()
    {
        System.Console.WriteLine("Welcome to the program!");
    }
    static string Name()
    {
        System.Console.WriteLine("What is your Name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int FavNumber()
    {
        System.Console.WriteLine("What is your favorite number? ");
        string input = Console.ReadLine();
        int favNumber = int.Parse(input);

        return favNumber;
    }

    static int SqrNumber(int FavNumber)
    {
        int sqrNumber = FavNumber * FavNumber;
        return sqrNumber;
    }

    static void Display(string name, int sqrNumber)
    {
        System.Console.WriteLine($"{name}, the square of your number is {sqrNumber}");
    }

    static void Main(string[] args)
    {
        Welcome();
        string name = Name();
        int favNumber = FavNumber();
        int sqrNumber = SqrNumber(favNumber);
        Display(name, sqrNumber);
    }
}