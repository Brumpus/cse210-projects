public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display2()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job pizza in _jobs)
        {   
            pizza.Display();
        }
    }
}