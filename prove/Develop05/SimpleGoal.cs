public class SimpleGoal : Goal{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points){
        _shortName = name;
        _description =description;
        _points = points;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
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
        string representation = $"SimpleGoal:{_shortName},{_description},{_points}";
        return representation;
    }
}