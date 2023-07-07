public class ChecklistGoal : Goal{
    private int _target;
    private int _bonus;
    private int _amountCompleted;
    public  ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name,description,points){
        _shortName = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }
    
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target){
            return true;
        }
        else{
            return false;
        }
    }
    public override string GetStringRepresentation()
    {
       string representation = $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
        return representation;
    }
    public override string GetDetailsString()
    {
         string checkBox;
        bool complete = IsComplete();
        if (complete == true){
            checkBox = "X";
        }
        else{
            checkBox = " ";
        }
        string details = $"[{checkBox}] {_shortName} ({_description}) -- Currently Completed : {_amountCompleted}/{_target} ";
        return details;
    }
}