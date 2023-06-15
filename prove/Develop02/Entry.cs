public class Entry {

    public string _dateTime = "";
    //The date and time that the user entered the text is stored here

    public string _prompt = "";
    //The prompt given to the user at the time of writing is stored here

    public string _diary = "";
    //The text inputed by the user is stored here

    public void Display()
    {
        Console.WriteLine($"{_dateTime}");
        
    }

}