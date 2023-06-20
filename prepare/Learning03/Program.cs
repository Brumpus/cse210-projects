using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(7);
        Fraction fraction3 = new Fraction(5,13);
        double fraction3Decimal = fraction3.GetDecimalValue();
        string fraction2string = fraction2.GetFractionString();
        int fraction3top = fraction3.GetTopNumber();


        Console.WriteLine($"{fraction3Decimal} {fraction2string} {fraction3top}");
    }
}