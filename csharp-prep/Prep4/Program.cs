using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        int userInput = -1;
        List<int> numbers = new List<int>();
        int sum = 0;
        int highNumber = 0;
        int lowNumber = 100000000;
        System.Console.WriteLine("Add numbers to a list! Type '0' when finished.");
        

        while (userInput != 0)
        {
            System.Console.WriteLine("Number to add:");
            string input = Console.ReadLine();
            userInput = int.Parse(input);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
            else
            {}

        }


        
        foreach(int number in numbers)
        {
            sum += number;
            if (number > highNumber)
            {highNumber = number;}
            if (number < lowNumber)
            {lowNumber = number;}
        }
        float avg = ((float)sum) / numbers.Count;

        System.Console.WriteLine($"The sum is: {sum}");
        System.Console.WriteLine($"The average is: {avg}");
        System.Console.WriteLine($"The Highest Number is: {highNumber}");
        System.Console.WriteLine($"The Lowest Number is: {lowNumber}");
        



    }
}