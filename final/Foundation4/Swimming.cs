public class Swimming : Activity{
    private string _date;
    private double _length;
    private double _speed;
    private double _distance;
    private double _pace;
    private double _laps;
    public Swimming(string date, double length, double laps){
        _date = date;
        _length = length;
        _laps = laps;
    }
    public override void GetMeasurements()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        _speed =(_distance / _length) * 60;
        _pace = 60 /_speed;
    }
    public override void GetSummary(){
        GetMeasurements();
        string summary = ($"{_date} Swimming - ({_length} Min) - {_distance} Miles, {_speed} MPH, {_pace} min per mile, {_laps} laps");
        Console.WriteLine(summary);
    }
}