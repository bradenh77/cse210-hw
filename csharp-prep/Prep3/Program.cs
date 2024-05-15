using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 10000;

        while (magicNumber != guess)
        {
            System.Console.WriteLine("Guess a number between 1 and 100: ");
            string input = Console.ReadLine();
            guess = int.Parse(input);

            if (guess > magicNumber)
            {
                System.Console.WriteLine("You guessed too high!\n");
            }
            else if (guess < magicNumber)
            {
                System.Console.WriteLine("You guessed too low!\n");
            }
            else
            {
                System.Console.WriteLine("You guessed the number!!");
            }
        }

        

    }
}