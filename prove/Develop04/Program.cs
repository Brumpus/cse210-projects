using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "fortnite";
        Activity activity = new Activity();
        do
        {Console.Clear();
        Console.WriteLine("Please choose an option \n 1. Breathing activity \n 2. Reflecting activity \n 3. Listing activity \n 4. Quit");
        Console.Write("> ");
        choice = Console.ReadLine();
        if (choice == "1"){
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.Run();

        }
        else if (choice == "2")
        {
            ReflectingActivity reflectingActivity = new ReflectingActivity();
            reflectingActivity.Run();
        }
        else if (choice == "3")
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();

        }}while(choice != "4");

        Console.Clear();
        Console.WriteLine("Have a wonderful day :)");
        activity.ShowSpinner(4);

    }
}