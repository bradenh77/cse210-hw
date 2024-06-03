using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Scripture
{
    private string scripture = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not becasue ye see not, for ye reveive no witness until after the trial of your faith.";

    public List<Words> listWords = new List<Words>();

    public string GetScripture()
    {
        return scripture;
    }
    public void AddToList(Words word)
    {
        listWords.Add(word);
    }
    public void Display()
    {
        foreach (Words word in listWords)
        {
            if (word._show == true)
            {
                System.Console.Write($"{word._word} ");
            }
            else if (word._show == false)
            {
                string underscores = "";
                string wordString = word.ToString();

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
                        underscores += ".   ";
                    }
                    else
                    {
                        underscores += "_";
                    }
                    
                }
                System.Console.Write($"{underscores} ");

            }
            
        }
    }

    public void RandomWordUnderscore()
    {
        //string underscored = "";
        while (true)
        {
            Random rand = new Random();
            int randomIndex = rand.Next(0, listWords.Count);

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
        //string randomWord = listWords[randomIndex].ToString();

        //foreach (char letter in randomWord)
        //{
        //    underscored += "_";
        //}
        //return underscored;
    }
    
}