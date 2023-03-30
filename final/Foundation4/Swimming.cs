using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime aDate, int aMinutes, int aLaps) : base(aDate, aMinutes)
    {
        _laps = aLaps;
    }

    public override void GetSummary()
    {
        base.GetSummary();
    }
}