using System;

class Swimming : Activity
{
    // 1 lap is equal to 50 meters
    private double _laps;
    double _speed;

    public Swimming(string aDate, int aMinutes, int aLaps) : base(aDate, aMinutes)
    {
        _laps = aLaps;
        _speed = ((GetLaps() * 50) / _minutes / 60);
    } 

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} / {GetType()} / ({_minutes} min) Distance: {GetLaps()*50} Meters, Pace: {Math.Round(_speed, 2)} m/s, Speed: {Math.Round(_speed * 2.2369, 2)} mph");
        Console.WriteLine();
    }

    public double GetLaps()
    {
        return _laps;
    }
}