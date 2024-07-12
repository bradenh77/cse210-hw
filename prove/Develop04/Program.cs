using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Activity yuhh = new Activity("","",0);
            Console.Clear();
            System.Console.WriteLine("Menu Options:");
            System.Console.WriteLine("  1. Start breathing activity\n  2. Start reflection activity\n  3. Start listing activity\n  4. Quit");
            System.Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Breathing breath1 = new Breathing("Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                30);
                breath1.RunBreathing();

            }
            else if (input == "2")
            {
                Reflection ref1 = new Reflection("Reflection Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life",
                30);
                ref1.RunReflection();

            }
            else if (input == "3")
            {

            }
            else if (input == "4")
            {
                Environment.Exit(0);
            }
        }
    }
}