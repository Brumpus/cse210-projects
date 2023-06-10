using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numString = Console.ReadLine();
            int favNum = int.Parse(numString);
            return favNum;
        }
        static int SquareNumber(int favNum)
        {
            int squaredNum = favNum * favNum;
            return squaredNum;
        }
        static void DisplayResult(string userName, int squaredNum)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squaredNum}.");
        }
        static void main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int number = PromptUserNumber();
            int squaredNum = SquareNumber(number);
            DisplayResult(userName, squaredNum);
        }

        main();
    }
}