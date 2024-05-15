using System;

class Prompt
{
    public string promptGenerator()
    {
        List<string> prompts = new();

        string prompt1 = "What was the highlight of your day?";
        string prompt2 = "What did you struggle with today?";
        string prompt3 = "How did you help someone today?";
        string prompt4 = "What interactions did you make with others today?";
        string prompt5 = "What do you want to remember from today?";

        prompts.Add(prompt1);
        prompts.Add(prompt2);
        prompts.Add(prompt3);
        prompts.Add(prompt4);
        prompts.Add(prompt5);

        Random randomPrompt = new();
        int index = randomPrompt.Next(prompts.Count);
        return prompts[index];


    }
    
}