using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string textGradePercentage = Console.ReadLine();
        float gradePercentage = float.Parse(textGradePercentage);
        string grade;
        if (gradePercentage >= 90)
        {
            grade = "A";
        }
        else if (gradePercentage >= 80)
        {
            grade = "B";
        }
        else if (gradePercentage >= 70)
        {
            grade = "C";
        }
        else if (gradePercentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't make it, better luck next time :(");
        }

    }
}