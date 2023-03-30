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
        Console.WriteLine($"{_date} / {GetType()} / ({_minutes} min) Distance: {_distance} Miles, Pace: {_distance/ (_minutes/60)}, Speed:  mph");
        Console.WriteLine();
    }
}