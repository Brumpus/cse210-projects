using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        string date = "7/17/23";
        string time = "7:00 PM";
        Address address = new Address("Schlattville", "1234 Tax street", "Big City", "USA");
        Reception reception = new Reception("Our Wedding!", "Come Celebrate our marriage!", address, "7/17/23", "7:00 PM", "RSVPEMAIL@Yahoo.com");
        events.Add(reception);
        OutdoorEvent outdoorEvent = new OutdoorEvent("The BIG hike", "Come hike the big mountain with us!", address, date, time, "Sunny");
        events.Add(outdoorEvent);
        Lecture lecture = new Lecture("History of speedrunning", "Come see Professor Olimar talk about the history of videogame speedrunning", address, date, time, 350, "Professor Olimar");     
        events.Add(lecture);
        foreach(Event thing in events){
            string description1 = thing.GetShortDescription();
            Console.WriteLine(description1);
        } 
        string receptionDesc0 = reception.GetStandardDescription();
        Console.WriteLine(receptionDesc0);
        string outdoorDesc0 = outdoorEvent.GetStandardDescription();
        Console.WriteLine(outdoorDesc0);
        string lectureDesc0 = lecture.GetStandardDescription();
        Console.WriteLine(lectureDesc0);
        string receptionDesc = reception.GetDetailedDescription();
        string outdoorDesc = outdoorEvent.GetDetailedDescription();
        string lectureDesc = lecture.GetDetailedDescription();
        Console.WriteLine(receptionDesc);
        Console.WriteLine(outdoorDesc);
        Console.WriteLine(lectureDesc);
    }
}