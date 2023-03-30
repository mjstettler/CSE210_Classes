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
        Console.WriteLine("\n---Full Details---\n");
        Console.WriteLine($"Event: {_eventTitle}\nDescription: {_description}\nSpeaker: {_speaker}\nCapacity: {_capacity} People\nDate: {_date}\nTime: {_time}\nAddress: {_venuAddress.DisplayAddress()}");
        Console.WriteLine();
    }
}