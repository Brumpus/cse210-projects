using System.IO;
public class GoalManager{

    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager(){

    }
    public void Start(){
        string choice = "0";
        Console.Clear();
        do{
        DisplayPlayerInfo();
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Goal program! Please choose an option.");
        Console.WriteLine("1.Create a new goal \n2.View goals list \n3.Save current goals list \n4.Load goals list \n5.Record event \n6.Quit");
        Console.Write("> ");
        choice = Console.ReadLine();
        if (choice == "1"){
            CreateGoal();
        }
        else if(choice == "2"){
            ListGoalDetails();
        }
        else if(choice == "3"){
            SaveGoal();
        }
        else if(choice == "4"){
            LoadGoal();
        }
        else if(choice == "5"){
            RecordEvent();
        }
        
        }while(choice != "6");

        
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
        int goalNumber = 0;
        foreach(Goal goal in _goals){
            string details = goal.GetDetailsString();
            goalNumber += 1;
            Console.WriteLine($"{goalNumber}. {details}");
        }
    }
    public void CreateGoal(){
        Console.WriteLine("Which goal would you like to create?");
        ListGoalNames();
        Console.Write("> ");
        string desiredGoal = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        Console.Write("> ");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of your goal?");
        Console.Write("> ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points do you want this goal to be worth ?");
        Console.Write("> ");
        string points = Console.ReadLine();
        if(desiredGoal == "1"){
            SimpleGoal simpleGoal = new SimpleGoal(name,description,points);
            _goals.Add(simpleGoal);
        }
        else if(desiredGoal == "2"){
            EternalGoal eternalGoal = new EternalGoal(name,description,points);
            _goals.Add(eternalGoal);
        }
        else if(desiredGoal == "3"){
            Console.WriteLine("How many times do you want to complete this goal?");
            Console.Write(">");
            string targetText = Console.ReadLine();
            Console.WriteLine("How many bonus points do you want this fully completed goal to be worth? ");
            Console.Write("> ");
            string bonusText = Console.ReadLine();
            int target = Int32.Parse(targetText);
            int bonus = Int32.Parse(bonusText);
            ChecklistGoal checklistGoal = new ChecklistGoal(name,description,points,target,bonus,0);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent(){
        ListGoalDetails();
        Console.WriteLine("Which goal would you like to make a record for?");
        Console.Write("> ");
        string goalPickerText = Console.ReadLine();
        int goalPicker = Int32.Parse(goalPickerText);
        goalPicker -= 1;
        Goal goal = _goals[goalPicker];
        goal.RecordEvent();
        int points = Int32.Parse(goal._points);
        _score += points;
    }
    public void SaveGoal(){
        using (StreamWriter outputFile = new StreamWriter("goals.txt")){
            outputFile.WriteLine($"{_score}");
            foreach(Goal goal in _goals){
                string representation = goal.GetStringRepresentation();
                outputFile.WriteLine(representation);
            }
        }
    }
    public void LoadGoal(){
        string line1 = File.ReadLines("goals.txt").First();
        int totalPoints = Int32.Parse(line1);
        _score += totalPoints;
        string[] lines = System.IO.File.ReadAllLines("goals.txt");
        List<string> goalList = new List<string>();
        foreach (string line in lines){
            goalList.Add(line);
        }
            goalList.RemoveAt(0);
            foreach(string line in goalList){
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
