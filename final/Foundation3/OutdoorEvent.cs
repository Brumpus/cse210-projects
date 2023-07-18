public class OutdoorEvent : Event{
    private string _title;
    private string _description;
    private Address _address;
    private string _date;
    private string _time;
    private string _type = "Outdoor Event";
    private string _weather;
    public OutdoorEvent(string title, string description, Address address, string date, string time, string weather) : base(title,description,address,date,time){
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
        _weather = weather;
    }
    public string GetDetailedDescription(){
        string addressString = _address.GetAddress();
        string description = ($"{_title} - {_date} - {_time}\n{addressString}\n{_type} - {_description}\n The forecasted weather is {_weather}");
        return description;
    }
    public string GetStandardDescription(){
        string addressString = _address.GetAddress();
        string description = ($"{_title} - {_date} - {_time}\n{addressString}\n{_type} - {_description}");
        return description;        
    }
}