using System;

class Activity
{
    protected string _date;
    protected double _minutes;

    public Activity(string aDate, int aMinutes)
    {
        _date = aDate;
        _minutes = aMinutes;
    }

    public virtual void GetSummary()
    {
        
    }
}