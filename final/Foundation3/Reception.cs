using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string aTitle, string aDescription, string aDate, string aTime, string aAddress) : base(aTitle, aDescription, aDate, aTime, aAddress)
    {
        _rsvpEmail = $"Seating is limited, please send RSVP to notAflake@wedding.com 2 weeks before {GetDate()}.";
    }

    public override void FullDetails()
    {
        Console.WriteLine("\n---Full Details---\n");
        Console.WriteLine($"Event: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress:{_venuAddress.DisplayAddress()}\nRSVP: {_rsvpEmail}");
        Console.WriteLine();
    }
}