using System;

class Program
{
    static void Main(string[] args)
    {
        var Frac1 = new Fraction();
        string text = Frac1.GetFractionString();
        Console.WriteLine(text);

        double decimalNumber = Frac1.GetDecimalValue();
        Console.WriteLine(decimalNumber);

        var Frac2 = new Fraction(5);
        string f2text = Frac2.GetFractionString();
        Console.WriteLine(f2text);
        double decimalNumber2 = Frac2.GetDecimalValue();
        Console.WriteLine(decimalNumber2);

        var Frac3 = new Fraction(3,4);
        string text3 = Frac3.GetFractionString();
        Console.WriteLine(text3);
        double decimalNumber3 = Frac3.GetDecimalValue();
        Console.WriteLine(decimalNumber3);

        var Frac4 = new Fraction(1,3);
        string text4 = Frac4.GetFractionString();
        Console.WriteLine(text4);
        double decimalNumber4 = Frac4.GetDecimalValue();
        Console.WriteLine(decimalNumber4);
    }
}