using System;
using System.IO;


class Program
{
    static void Main(string[] args)
    {   Random randomGenerator = new Random();
        
        List<Scripture> scriptures = new List<Scripture>();

        string file = "scriptures.txt";
        string escapeHatch = "";
        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorizer program! Are you ready to memorize some scriptures?");
        Console.WriteLine("Type quit at any time to close the program.");
        Console.WriteLine("Press ENTER to continiue");
        Console.WriteLine("");
        Console.Write("> ");
        escapeHatch = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        int scriptNumber = 0;
        
        foreach (string script in lines)
            {
                scriptNumber += 1;
                string[] parts = script.Split("|");
                string book = parts[0];
                int chapter = Int32.Parse(parts[1]);
                int startverse = Int32.Parse(parts[2]);
                int endverse = Int32.Parse(parts[3]);
                string stuff = parts[4];
                if(startverse == endverse)
                {
                    Reference reference1 = new Reference(book,chapter,startverse);
                    Scripture scripture1 = new Scripture(reference1, stuff);
                    scriptures.Add(scripture1);
                }
                else
                {
                    Reference reference1 = new Reference(book,chapter,startverse,endverse);
                    Scripture scripture1 = new Scripture(reference1, stuff);
                    scriptures.Add(scripture1);
                    
                }
                
            }
        int scriptPicker = randomGenerator.Next(0,scriptNumber);
        Console.Clear();
        Scripture scripture2 = scriptures[scriptPicker];
        string scripture3 = scripture2.GetDisplayText();
        Console.WriteLine(scripture3);
        escapeHatch = Console.ReadLine();
        while(escapeHatch != "quit")
        {
            Console.Clear();

            scripture2.HideRandomWords();
            scripture3 = scripture2.GetDisplayText();
            Console.WriteLine(scripture3);
            if(scripture2.IsCompletelyHidden() == true)
            {
                Console.WriteLine("That's all the words!");
                escapeHatch = "quit";
            }
            else
            {
                escapeHatch = Console.ReadLine();
            }
            

           
            


        }
        
    }
}