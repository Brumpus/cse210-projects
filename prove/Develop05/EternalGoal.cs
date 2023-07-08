public class EternalGoal : Goal{
    DateTime _rightNow = DateTime.Now;
    int _streak;
    
    
    public EternalGoal(string name, string description, string points, int streak) : base(name, description, points){
        _shortName = name;
        _description = description;
        _points = points;
        _streak = streak;
    }
    public override void RecordEvent()
    {
        DateTime _today = _rightNow.Date;
        DateTime _tomorrow = _today.AddDays(1);
        Console.WriteLine("Nice!");
        if (DateTime.Now.Date == _tomorrow){
            _streak += 1;
        }
        else{
            _streak = 0;
            Console.WriteLine("Looks like your daily streak was broken :( ");
            Console.WriteLine("Better luck next time.");
        }
        if(_streak == 30){
            Console.WriteLine("Congratulations! you have formed a habit!");
            _points = "500";
        }
    }
    public override bool IsComplete()
    {
        return false;
    }

  
    public override string GetStringRepresentation()
    {
        string representation = $"EternalGoal:{_shortName},{_description},{_points}";
        return representation;
    }
}