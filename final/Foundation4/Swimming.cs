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
        double dist = (_minutes/60)*(_speed * 2.2369);
        decimal number = Convert.ToDecimal(Math.Round(_minutes/dist,2));
        int wholeNum = Convert.ToInt32(decimal.Truncate(number));
        decimal seconds = Math.Round(((number - wholeNum)*60));
        Console.WriteLine($"{_date} / {GetType()} / ({_minutes} min) Distance: {Math.Round(GetLaps()*50/1000*.62, 2)} Miles, Pace: {wholeNum}:{seconds} min/mile, Speed: {Math.Round(_speed * 2.2369, 2)} mph");
        Console.WriteLine();
    }

    public double GetLaps()
    {
        return _laps;
    }
}