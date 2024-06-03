using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();

        Words and1 = new Words("And");
        Words now = new Words("now,");
        Words i = new Words("I,");
        Words moroni = new Words("Moroni,");
        Words would = new Words("would");
        Words speak = new Words("speak");
        Words somewhat = new Words("somewhat");
        Words concerning = new Words("concerning");
        Words these = new Words("these");
        Words things = new Words("things;");
        Words i2 = new Words("I");
        Words would2 = new Words("would");
        Words show = new Words("show");
        Words unto = new Words("unto");
        Words the = new Words("the");
        Words world = new Words("world");
        Words that = new Words("that");
        Words faith = new Words("faith");
        Words iss = new Words("is");
        Words things2 = new Words("things");
        Words which = new Words("which");
        Words are = new Words("are");
        Words hoped = new Words("hoped");
        Words for_ = new Words("for");
        Words and = new Words("and");
        Words not = new Words("not");
        Words seen = new Words("seen;");
        Words wherefore = new Words("wherefore,");
        Words dispute = new Words("dispute");
        Words not2 = new Words("not");
        Words because = new Words("because");
        Words ye = new Words("ye");
        Words see = new Words("see");
        Words not3 = new Words("not,");
        Words for2 = new Words("for");
        Words ye2 = new Words("ye");
        Words receive = new Words("receive");
        Words no = new Words("no");
        Words witness = new Words("witness");
        Words until = new Words("until");
        Words after = new Words("after");
        Words the2 = new Words("the");
        Words trial = new Words("trial");
        Words of = new Words("of");
        Words your = new Words("your");
        Words faith2 = new Words("faith.");






        scripture.AddToList(and1);
        scripture.AddToList(now);
        scripture.AddToList(i);
        scripture.AddToList(moroni);
        scripture.AddToList(would);
        scripture.AddToList(speak);
        scripture.AddToList(somewhat);
        scripture.AddToList(concerning);
        scripture.AddToList(these);
        scripture.AddToList(things);
        scripture.AddToList(i2);
        scripture.AddToList(would2);
        scripture.AddToList(show);
        scripture.AddToList(unto);
        scripture.AddToList(the);
        scripture.AddToList(world);
        scripture.AddToList(that);
        scripture.AddToList(faith);
        scripture.AddToList(iss);
        scripture.AddToList(things2);
        scripture.AddToList(which);
        scripture.AddToList(are);
        scripture.AddToList(hoped);
        scripture.AddToList(for_);
        scripture.AddToList(and);
        scripture.AddToList(not);
        scripture.AddToList(seen);
        scripture.AddToList(wherefore);
        scripture.AddToList(dispute);
        scripture.AddToList(not2);
        scripture.AddToList(because);
        scripture.AddToList(ye);
        scripture.AddToList(see);
        scripture.AddToList(not3);
        scripture.AddToList(for2);
        scripture.AddToList(ye2);
        scripture.AddToList(receive);
        scripture.AddToList(no);
        scripture.AddToList(witness);
        scripture.AddToList(until);
        scripture.AddToList(after);
        scripture.AddToList(the2);
        scripture.AddToList(trial);
        scripture.AddToList(of);
        scripture.AddToList(your);
        scripture.AddToList(faith2);
        
        Console.Clear();
        scripture.Display();

        while (true)
        {
            System.Console.WriteLine("\n\nPress enter to hide words, type quit to quit");

            string input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                scripture.RandomWordUnderscore();
                scripture.RandomWordUnderscore();
                scripture.RandomWordUnderscore();
                scripture.Display();
            }
            else if (input == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("\nInvalid input, try again.\n");
                scripture.Display();
                continue;
            }
        }

        
        
        
    }
}