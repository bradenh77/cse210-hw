using System;

class Words
{
    public string _word = "";

    public bool _show = true;

    public Words(string words)
    {
        _word = words;
    }

    public override string ToString()
    {
        return _word;
    }

    public void SetShowFalse()
    {
        _show = false;
    }

    
    
}