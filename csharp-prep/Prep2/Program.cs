using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //Prompts input for grade percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        //Sets the variables for the program
        string letter = "";
        string modifier = "";

        //Calculates letter grade based on grade percent
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        //Calculates whether the grade will have a + or minus, no A+ and no modifier for F
        if ((percent % 10) >= 7 && percent < 97 && percent > 59)
        {
            modifier = "+";
        }
        else if ((percent % 10) <= 3 && percent >59)
        {
            modifier = "-";
        }
        else
        {
            modifier = "";
        }

        //Prints the grade for the user
        Console.WriteLine($"Your grade is: {letter}{modifier}");

        //If the user inputs a grade percent 70 or higher they pass, otherwise it's a fail
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}