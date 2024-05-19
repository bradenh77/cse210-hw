using System;
using System.Runtime.Intrinsics.Arm;
using System.IO;

public class Entry
{

    public List<string> listEntries = new List<string>();
    DateTime currentDateTime = DateTime.Now;

    public void WriteEntry()
    {
        string entry = "";
        Prompt randomPrompt = new Prompt();
        string prompt = randomPrompt.promptGenerator();
        System.Console.WriteLine($"Respond to this prompt: {prompt}\n");

        entry = Console.ReadLine();

        entry = $"\n{currentDateTime} \nPrompt: {prompt} \n{entry}\n|";

        listEntries.Add(entry);
       
        
    }
    public void DisplayEntries()
    {
        foreach (var entry in listEntries)
        {
            Console.WriteLine(entry);
        }
    }
    
}
    
