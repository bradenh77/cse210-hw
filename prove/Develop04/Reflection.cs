using System;
using System.Runtime.InteropServices.Marshalling;

class Reflection: Activity
{

    private List<string> _prompts = new List<string>();

    private List<string> _questions = new List<string>();

    //constructor
    public Reflection(string name, string desc, int dur) : base(name,desc,dur)
    {

    }

    public void RunReflection()
    {
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?"); 

        ActIntro();

        System.Console.WriteLine("\nConsider the following prompt:\n");

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        System.Console.WriteLine($" --- {randomPrompt} --- \n");
        System.Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();

        System.Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        System.Console.Write("You may begin in ");
        for (int i = 5; i >= 0; i--)
        {
            System.Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        Console.Clear();

        System.Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDur());

        while (DateTime.Now < futureTime)
        {
            System.Console.WriteLine(RandomQuestion());

            for (int iii = 10; iii >= 0; iii--)
            {
                if (DateTime.Now < futureTime)
                {
                    SpinnyThingy();
                }
                else
                {
                    continue;
                }
                
            }
        }

        System.Console.WriteLine($"\nWell Done! You have completed {GetDur()} seconds of the Reflection Activity!");
        for (int iiii = 5; iiii >= 0; iiii--)
        {
            SpinnyThingy();
        }


    }

    private string RandomQuestion()
    {
    Random rand = new Random();
    int randIndex = rand.Next(_questions.Count);
    string randQuestion = _questions[randIndex];

    return randQuestion;
    }

    
    


}