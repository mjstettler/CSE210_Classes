using System;

class Cycling : Activity
{
    private double _mph;

    public Cycling(DateTime aDate, int aMinutes, double aSpeed) : base(aDate, aMinutes)
    {
        _mph = aSpeed;
    }

    public override void GetSummary()
    {
        base.GetSummary();
    }
}