using System;

class Cycling : Activity
{
    private double _mph;

    public Cycling(string aDate, int aMinutes, double aSpeed) : base(aDate, aMinutes)
    {
        _mph = aSpeed;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} / {GetType()} / ({_minutes} min)");
        Console.WriteLine();
    }
}