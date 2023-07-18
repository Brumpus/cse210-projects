public class Lecture : Event{
    private string _title;
    private string _description;
    private Address _address;
    private string _date;
    private string _time;
    private string _type = "Lecture";
    private string _lecturer;
    private int _capacity;
    public Lecture(string title, string description, Address address, string date, string time, int capacity, string lecturer) : base(title,description,address,date,time){
        _title = title;
        _description = description;
        _address = address;
        _date = date;
        _time = time;
        _capacity = capacity;
        _lecturer = lecturer;
    }
    public string GetDetailedDescription(){
        string addressString = _address.GetAddress();
        string description = ($"{_title} - {_date} - {_time}\n{addressString}\n{_type} - {_description}\n The speaker is {_lecturer}\nCapacity: {_capacity} persons");
        return description;
    }
    public string GetStandardDescription(){
        string addressString = _address.GetAddress();
        string description = ($"{_title} - {_date} - {_time}\n{addressString}\n{_type} - {_description}");
        return description;        
    }
}