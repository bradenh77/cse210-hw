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



    public void SetDur()
    {
        string input = Console.ReadLine();
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