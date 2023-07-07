using System.IO;
public class GoalManager{

    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(){

    }
    public void Start(){
        // code for the main menu
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames(){
       Console.WriteLine("1.Simple Goal");
       Console.WriteLine("2.Eternal Goal");
       Console.WriteLine("3.Checklist goal");
    }
    public void ListGoalDetails(){
        foreach(Goal goal in _goals){
            string details = goal.GetDetailsString();
            Console.WriteLine(details);
        }
    }
    public void CreateGoal(){
        //code for creating a goal
    }
    public void RecordEvent(){
        //code for completing a goal
    }
    public void SaveGoal(){
        using (StreamWriter outputFile = new StreamWriter("goals.txt")){
            foreach(Goal goal in _goals){
                string representation = goal.GetStringRepresentation();
                outputFile.WriteLine(representation);
            }
        }
    }
    public void LoadGoal(){
         string[] lines = System.IO.File.ReadAllLines("goals.txt");
        foreach (string line in lines){
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goal = parts[1];
            if(goalType == "SimpleGoal"){
                string[] goalParts = parts[1].Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                string points = goalParts[2];
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            }
            else if (goalType == "EternalGoal"){
                string[] goalParts = parts[1].Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                string points = goalParts[2];
                EternalGoal eternalGoal = new EternalGoal(name,description,points);
                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal"){
                string[] goalParts = parts[1].Split(",");
                string name = goalParts[0];
                string description = goalParts[1];
                string points = goalParts[2];
                string bonusText = goalParts[3];
                int bonus = Int32.Parse(bonusText);
                string targetText = goalParts[4];
                int target = Int32.Parse(targetText);
                string amountCompletedText = goalParts[5];
                int amountCompleted = Int32.Parse(amountCompletedText);
                ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus,amountCompleted);
                _goals.Add(checklistGoal);

            }
        }
    }
}