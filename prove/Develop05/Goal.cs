public abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal(string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        string checkBox;
        bool complete = IsComplete();
        if (complete == true){
            checkBox = "X";
        }
        else{
            checkBox = " ";
        }
        string details = $"[{checkBox}] {_shortName} ({_description})";
        return details;
    }
    public abstract string GetStringRepresentation();
    
}