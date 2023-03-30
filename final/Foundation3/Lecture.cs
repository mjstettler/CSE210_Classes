using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string aSpeaker, int aCapacity, string aTitle, string aDescription, string aDate, string aTime, string aAddress) : base(aTitle, aDescription, aDate, aTime, aAddress)
    {
        _speaker = aSpeaker;
        _capacity = aCapacity;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"{_eventTitle}, {_description}, {_date}, {_time}, {_venuAddress}");
    }
}