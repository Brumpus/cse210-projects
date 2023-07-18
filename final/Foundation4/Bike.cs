public class StationaryBike : Activity{
    private string _date;
    private double _length;
    private double _speed;
    private double _distance;
    private double _pace;
    
    
    public StationaryBike(string date, double length, double speed){
        _date = date;
        _length = length;
        _speed = speed;
    }
    public override void GetMeasurements()
    {
        _distance = _length*(_speed/60);
        _pace = (60 / _speed);
    }

    public override void GetSummary(){
        GetMeasurements();
        string summary = ($"{_date} Biking - ({_length} Min) - {_distance} Miles, {_speed} MPH, {_pace} min per mile");
        Console.WriteLine(summary);
    }
}