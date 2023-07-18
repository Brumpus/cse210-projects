using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activites = new List<Activity>();
        Running running = new Running("07 JUL 2023", 30, 2);
        activites.Add(running);
        Swimming swimming = new Swimming("07 JUL 2023", 30, 10);
        activites.Add(swimming);
        StationaryBike biking = new StationaryBike("07 JUL 2023", 30, 42);
        activites.Add(biking);
        foreach(Activity activity in activites){
            activity.GetSummary();
        }
    }
}