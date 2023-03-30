using System;

class OutdoorGathering : Event
{
    private string _weatherDisclaimer;

    public OutdoorGathering(string aTitle, string aDescription, string aDate, string aTime, string aAddress) : base(aTitle, aDescription, aDate, aTime, aAddress)
    {
        _weatherDisclaimer = "In case of inclement weather the event will be moved to the Dee Event Center in Ogden, Utah.";
    }

    public override void FullDetails()
    {
        base.FullDetails();
    }
}