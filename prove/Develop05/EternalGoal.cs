public class EternalGoal : Goal{
    public EternalGoal(string name, string description, string points) : base(name, description, points){
        _shortName = name;
        _description = description;
        _points = points;
    }
    public override void RecordEvent()
    {
        Console.WriteLine("Nice!");
    }
    public override bool IsComplete()
    {
        return false;
    }

    // public override string GetDetailsString()
    // {
    //     string checkBox;
    //     bool complete = IsComplete();
    //     if (complete == true){
    //         checkBox = "X";
    //     }
    //     else{
    //         checkBox = " ";
    //     }
    //     string details = $"[{checkBox}] {_shortName} ({_description})";
    //     return details;
    // }
    public override string GetStringRepresentation()
    {
        string representation = $"EternalGoal:{_shortName},{_description},{_points}";
        return representation;
    }
}