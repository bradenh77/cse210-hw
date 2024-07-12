using System;

class Activity
{

    protected string _activityName;

    protected int _durationSeconds;

    protected string _activityDesc;


    public Activity(string name, string desc, int dur)
    {
        _activityName = name;
        _activityDesc = desc;
        _durationSeconds = dur;
    }



    public void SetDur(string input)
    {
        int intInput = int.Parse(input);
        _durationSeconds = intInput;
    }
    

    public string GetDesc()
    {
        return _activityDesc;
    }

    public int GetDur()
    {
        return _durationSeconds;
    }

    public string GetName()
    {
        return _activityName;
    }

    public void ActIntro()
    {
        Console.Clear();
        System.Console.WriteLine($"Welcome to {_activityName}!\n");
        System.Console.WriteLine(_activityDesc);
        System.Console.WriteLine("\nHow long, in seconds, would you like your session? ");
        string input = Console.ReadLine();
        SetDur(input);

        Console.Clear();

        System.Console.WriteLine("Get Ready...");
        for (int ii = 3; ii >= 0; ii--)
        {
            SpinnyThingy();
        }

        Console.Clear();
    }

    public void SpinnyThingy()
    {
        Console.Write("/");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("-");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("\\");
        Thread.Sleep(250);
        Console.Write("\b");
        Console.Write("|");
        Thread.Sleep(250);
        Console.Write("\b");
    }


    





}