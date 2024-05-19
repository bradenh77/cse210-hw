using System;

public class Prompt
{

    public List<string> prompts = new List<string> {"What was the highlight of your day?",
    "What did you struggle with today?",
    "How did you help someone today?",
    "What interactions did you make with others today?",
    "What do you want to remember from today?"};


    public string promptGenerator()
    {
        Random randomPrompt = new();
        int index = randomPrompt.Next(prompts.Count);
        string randomEntity = prompts[index];
        return randomEntity;
    }
    
}