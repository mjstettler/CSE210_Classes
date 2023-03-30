using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Lecture Bill = new Lecture("Bill Nye", 600, "Science is cool!", "Science demonstration of the effects of Liquid nitrogen on objects", "4/1/2023", "10:00 AM", "-320 Degree Dr.,Kelvin,Alaska,USA");
        events.Add(Bill);

        OutdoorGathering woods = new OutdoorGathering("How to start a Fire", "Things are about to get heated! We hope you will join us in this educational lesson on how and why we should start Fires.", "07/04/2025", "4:51 PM", "451 Heat Street,Muy Caliente,Mexico,Mexico");
        events.Add(woods);

        Reception wedding = new Reception("M & M Wedding", "Join us for the Wedding celebration of M & M", "05/26/2012", "5:30 AM", "1020 Waldo way,Bigfoot,Montana,USA");
        events.Add(wedding);

        foreach (Event plan in events)
        {
            plan.FullDetails();
        }

        foreach (Event plan in events)
        {
            plan.StandardDetails();
        }
        
        foreach (Event plan in events)
        {
            Type eventType = plan.GetType();
            Console.WriteLine(plan.ShortDetails(eventType));
        }
        
    }
}