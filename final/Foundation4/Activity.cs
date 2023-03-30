using System;

class Activity
{
    protected DateTime _date;
    protected int _minutes;

    public Activity(DateTime aDate, int aMinutes)
    {
        _date = aDate;
        _minutes = aMinutes;
    }

    public virtual void GetSummary()
    {
        
    }
}