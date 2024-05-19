using System;
using System.IO;

public class Menu
{
    

    public void RunMenu()
    {
        Entry entry = new Entry();
        while (true)
        {
            System.Console.WriteLine("Type the number you want to do!\n1. Write\n2. Display Journal\n3. Load\n4. Save\n5. Quit");
            string input = Console.ReadLine();
            int intInput = int.Parse(input);
            if (intInput == 1)
            {
                entry.WriteEntry();
            }
            else if (intInput == 2)
            {
                entry.DisplayEntries();
            }
            else if (intInput == 3)
            {
                System.Console.WriteLine("What is the name of the file?");

                


                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("|");

                    string firstName = parts[0];
                    string lastName = parts[1];
                }
            }
            else if (intInput == 4)
            {
                System.Console.WriteLine("Where would you like to save your Entries??");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (string entrys in entry.listEntries)
                    {
                        outputFile.WriteLine(entrys);
                    }
                    
                    

                }
            }
            else if (intInput == 5)
            {
                Environment.Exit(0);
            }
            else 
            {
                System.Console.WriteLine("Invalid input, try again!\n");
            }
        }



    }








}