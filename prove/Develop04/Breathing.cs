using System;
using System.ComponentModel.DataAnnotations.Schema;


class Breathing: Activity
{

    //constructor
    public Breathing(string name, string desc, int dur) : base(name,desc,dur)
    {

    }
}