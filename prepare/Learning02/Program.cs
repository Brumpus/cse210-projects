using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Awesomesoft";
        job1._startYear = 2000;
        job1._endYear = 2001;
        

        Job job2 = new Job();
        job2._jobTitle = "Head Pizza Chef";
        job2._company = "Peppino's Pizzeria";
        job2._startYear = 2001;
        job2._endYear = 2023;
        

        Resume resume1 = new Resume();
        resume1._name = "John Noise";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display2();

        
    }
}