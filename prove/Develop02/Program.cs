using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        string choice = "0";
        do{

        
        Console.WriteLine("Welcome to the journal program, please choose an option.");
        Console.WriteLine("1). Write \n 2). Display \n 3). Save \n 4). Load \n 5). Quit");
        Console.Write("> ");
        choice = Console.ReadLine();
        
            if (choice == "1")
            {
                //write a new entry
                Prompt prompt1 = new Prompt();
                Entry diary = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                diary._date = theCurrentTime.ToShortDateString();
                diary._prompt = prompt1.GetRandomPrompt();
                Console.Write($"{diary._date}|");
                Console.WriteLine($" {diary._prompt}|");
                Console.Write("> ");
                diary._diary = Console.ReadLine();
                journal1.AddEntry(diary);
                choice = "0";

            }
            else if (choice == "2")
            {
                //Display all the entries
                journal1.DisplayAll();
                choice = "0";
            }
            else if (choice == "3")
            {
                //Save all tthe entries to a file
                Console.Write("What do you want to name your file? \n > ");
                string file = Console.ReadLine();
                journal1.SaveToFile(file);
                choice = "0";
            }
            else if (choice == "4")
            {
                //Load all the entries from a file
                Console.Write("What file would you like to load? \n>  ");
                string file = Console.ReadLine();
                journal1.LoadFromFile(file);
                choice = "0";
            }
        
        }while(choice != "5");

        

         
    }

    

}