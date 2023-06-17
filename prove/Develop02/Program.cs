using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        string choice = "0";
        int entryNumber = 0;
        do{

        
        Console.WriteLine("Welcome to the journal program, please choose an option.");
        Console.WriteLine("1). Write \n2). Display \n3). Save \n4). Load \n5). Quit");
        Console.Write("> ");
        choice = Console.ReadLine();
        
            if (choice == "1")
            {
                //write a new entry
                Console.WriteLine("");
                Prompt prompt1 = new Prompt();
                Entry diary = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                entryNumber += 1;
                diary._date = theCurrentTime.ToShortDateString();
                diary._prompt = prompt1.GetRandomPrompt();
                Console.Write($"Date: {diary._date}|");
                Console.Write($" Entry: {entryNumber} |");
                Console.WriteLine($" Prompt: {diary._prompt}|");
                Console.Write("> ");
                diary._diary = Console.ReadLine();
                journal1._entryNumber = entryNumber;
                journal1.AddEntry(diary);
                choice = "0";

            }
            else if (choice == "2")
            {
                //Display all the entries
                Console.WriteLine("");
                journal1.DisplayAll(journal1);
                choice = "0";
            }
            else if (choice == "3")
            {
                //Save all tthe entries to a file
                Console.WriteLine("");
                Console.Write("What do you want to name your file? \n > ");
                string file = Console.ReadLine();
                journal1.SaveToFile(file);
                choice = "0";
            }
            else if (choice == "4")
            {
                //Load all the entries from a file
                Console.WriteLine("");
                Console.Write("What file would you like to load? \n>  ");
                string file = Console.ReadLine();
                journal1.LoadFromFile(file);
                choice = "0";
            }
        
        }while(choice != "5");

        

         
    }

    

}