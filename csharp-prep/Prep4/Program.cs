using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = 42;
        do
        {
            Console.Write("Enter Number: ");
            string numberText = Console.ReadLine();
            number = int.Parse(numberText);
            numbers.Add(number);
        }while(number != 0);
        float total = 0;
        int bigGuy = 0;
        foreach (int num in numbers)
        {
            total += num;
           
            if (num > bigGuy)
            {
                bigGuy = num;
            }
        }
        Console.WriteLine($"The sum is : {total}");
        float length = numbers.Count;
        length --;
        float average = total / length;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {bigGuy}");
    }
}