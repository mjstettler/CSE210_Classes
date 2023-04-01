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
        double dist = (_minutes/60)*_mph;
        decimal number = Convert.ToDecimal(Math.Round(_minutes/dist,2));
        int wholeNum = Convert.ToInt32(decimal.Truncate(number));
        decimal seconds = Math.Round(((number - wholeNum)*60));
        Console.WriteLine($"{_date} / {GetType()} / ({_minutes} min) Distance: {(_minutes/60)*_mph} Miles, Pace: {wholeNum}:{seconds}  min/mile, Speed: {Math.Round(_mph,1)} mph");
        Console.WriteLine();
    }
}