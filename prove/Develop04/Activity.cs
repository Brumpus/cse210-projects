using System.IO;

public class Activity 


{
    protected string _name;
    protected int _duration;
    protected string _description;

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like to do the exercise for? > ");
        _duration = Int32.Parse(Console.ReadLine());

    }

    public void DisplayEndingMessage()
    {
        Console.Write("Well done!");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(9);

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        do{
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/"); 
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }while(futureTime > DateTime.Now);
    }

    public void ShowCountDown(int seconds)
    {
        do{
            Console.Write($"{seconds}");
            seconds -= 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }while(seconds > 0);
        
    }
       
}

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "listing activity";
        _description = "This activity will guide you through making a list of moments or things you enjoy to help boost your mood.";
    }

    private string GetRandomPrompt()
    {
        string[] lines = System.IO.File.ReadAllLines("listPrompts.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        
        Random randomGenerator2 = new Random();
        int promptPicker = randomGenerator2.Next(0,5);
        string prompt = _prompts[promptPicker];
        return prompt;
    }

    public void Run()
    {
        Console.Clear();
        List<string> responses = new List<string>(); 

        string prompt = GetRandomPrompt();
        DisplayStartingMessage();
        Console.Write("Get Ready... ");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--{prompt}--");
        Console.Write ("You may begin in: ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        do
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _count += 1;
            responses.Add(response);

        }while(futureTime > DateTime.Now);

        Console.WriteLine($"You listed {_count} items! ");
        Console.WriteLine(" ");
        DisplayEndingMessage();
        

    }

}

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "breathing activity";
        _description = "This activity will help you relax by guiding you through some deep breathing. Clear your mind and focus on breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Console.Write("Get ready... ");
        ShowSpinner(4);
        Console.WriteLine("");

        do{
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.Write("Hold... ");
            ShowCountDown(7);
            Console.WriteLine("");
            Console.Write("Breathe out... ");
            ShowCountDown(8);
            Console.WriteLine("");
            Console.Clear();

        }while(futureTime > DateTime.Now);

        DisplayEndingMessage();
    }
}

public class ReflectingActivity : Activity
{
    public ReflectingActivity()
    {
        _name = "reflecting activity";
        _description = "This activity will give you the opportunity to reflect on different opportunities you've had in your life.";
    }
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    private void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"{question} > ");
        ShowSpinner(5);
        Console.ReadLine();
        Console.WriteLine("");
        
        
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--{prompt}--");
        Console.WriteLine("");
        Console.WriteLine("When you've thought of something, press the ENTER key.");
        Console.ReadLine();
    }
    private string GetRandomPrompt()

    {
        string[] lines = System.IO.File.ReadAllLines("reflectionPrompts.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        
        Random randomGenerator2 = new Random();
        int promptPicker = randomGenerator2.Next(0,5);
        string prompt = _prompts[promptPicker];
        return prompt;
    }

    private string GetRandomQuestion()
    {
        string[] lines = System.IO.File.ReadAllLines("questions.txt");
        foreach (string line in lines)
        {
            _questions.Add(line);
        }
        
        Random randomGenerator2 = new Random();
        int questionPicker = randomGenerator2.Next(0,5);
        string question = _questions[questionPicker];
        return question;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        DateTime startingTime = DateTime.Now;
        DateTime futureTime = startingTime.AddSeconds(_duration);
        DisplayPrompt();
        do
        {
            DisplayQuestion();
        }while(futureTime > DateTime.Now);

        DisplayEndingMessage();
    }


}