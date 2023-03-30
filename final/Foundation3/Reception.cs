using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string aTitle, string aDescription, string aDate, string aTime, string aAddress) : base(aTitle, aDescription, aDate, aTime, aAddress)
    {
        _rsvpEmail = $"Seating is limited, please RSVP to the happy couple 2 weeks before {GetDate()}.";
    }

    public override void FullDetails()
    {
        base.FullDetails();
    }
}