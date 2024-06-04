using System;

class Words
{
    private string _word = "";

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