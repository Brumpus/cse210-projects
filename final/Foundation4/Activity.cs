public abstract class Activity{
    private string _date;
    private string _length;
    private double _speed;
    private double _distance;
    private double _pace;
    public abstract void GetMeasurements();

    public abstract void GetSummary();
}