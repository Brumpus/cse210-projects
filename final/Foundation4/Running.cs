public class Running : Activity{
    private string _date;
    private double _length;
    private double _speed;
    private double _distance;
    private double _pace;
    public Running(string date, double length, double distance){
        _date = date;
        _length = length;
        _distance = distance;
    }
    public override void GetMeasurements()
    {
        _speed =(_distance / _length) * 60;
        _pace = 60 / _speed;
    }
    public override void GetSummary(){
        GetMeasurements();
        string summary = ($"{_date} Running - ({_length} Min) - {_distance} Miles, {_speed} MPH, {_pace} min per mile");
        Console.WriteLine(summary);
    }
}