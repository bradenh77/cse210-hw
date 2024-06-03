using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    //Sets the list containing Words classes to contain all the words in the scripture
    public List<Words> listWords = new List<Words>();

    //Method to add a Words object to the scripture list
    public void AddToList(Words word)
    {
        listWords.Add(word);
    }

    //Displays the whole scripture, including underscored words
    public void Display()
    {
        
        Refrence refrence = new Refrence();
        System.Console.WriteLine(refrence.GetReference());

        //Iterates through the list to display each object
        foreach (Words word in listWords)
        {

            //Checks the _show attribute each word object. If true displays the word normally, if not builds an underscore replacement
            if (word._show == true)
            {
                System.Console.Write($"{word._word} ");
            }
            else if (word._show == false)
            {

                //Sets empty underscore variable and gets a string of each word
                string underscores = "";
                string wordString = word.ToString();

                //Iterates through each letter and adds an underscore, keeps punctuation the same
                foreach (char letter in wordString)
                {
                    if (letter == ',')
                    {
                        underscores += ",";
                    }
                    else if (letter == ';')
                    {
                        underscores += ";";
                    }
                    else if (letter == '.')
                    {
                        underscores += ".";
                    }
                    else
                    {
                        underscores += "_";
                    }
                    
                }

                //Displays the underscored word
                System.Console.Write($"{underscores} ");

            }
            
        }
    }

    //Gets a random index from the list and changes the _show attribute to false
    public void RandomWordUnderscore()
    {
        

        while (true)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, listWords.Count);

            //Checks to see if all the words have been hidden, if yes skip the method
            if (listWords.All(word => !word._show))
            {
                break;
            }
            
            else
            {
                //Finds words that havn't been hidden already
                if (listWords[randomIndex]._show == true)
                {
                    listWords[randomIndex].SetShowFalse();
                    break;
                }
                else
                {
                    continue;
                }

            }
            
            
        }
        
    }
    
}