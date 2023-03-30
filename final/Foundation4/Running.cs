using System;

class Running : Activity
{
    private double _distance;

    public Running(DateTime aDate, int aMinutes, double aDistance) : base(aDate, aMinutes)
    {
        _distance = aDistance;
    }

    public override void GetSummary()
    {
        base.GetSummary();
    }
}