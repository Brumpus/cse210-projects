public class Event{
    private string _title;
    private string _description;
    private Address _address;
    private string _date;
    private string _time;
    private string _type = "Event";
    public Event(string title, string description, Address address, string date, string time){
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
    }
    public string GetShortDescription(){
        string addressString = _address.GetAddress();
        string description = ($"{_title} - {_date} - {_time}\n{addressString}\n{_description}");
        return description;
    }

}