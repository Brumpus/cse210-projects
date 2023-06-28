using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Quinton", "Math2", "69 - 420", "Page 777");
        WritingAssignment write1 = new WritingAssignment("Quinton", "Fortnite", "The industrial revolution and its consequences");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine(write1.GetWritingInformation());

    }
}