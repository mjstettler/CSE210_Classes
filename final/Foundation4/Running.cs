using System;

class Running : Activity
{
    private double _distance;

    public Running(string aDate, int aMinutes, double aDistance) : base(aDate, aMinutes)
    {
        _distance = aDistance;
    }

    public override void GetSummary()
    {
        decimal number = Convert.ToDecimal(Math.Round(_minutes/_distance,2));
        int wholeNum = Convert.ToInt32(decimal.Truncate(number));
        decimal seconds = Math.Round(((number - wholeNum)*60));
        Console.WriteLine($"{_date} / {GetType()} / ({_minutes} min) Distance: {_distance} Miles, Pace: {wholeNum}:{seconds} min/mile, Speed: {Math.Round(_distance/(_minutes/60),2)} mph");
        Console.WriteLine();
    }
}