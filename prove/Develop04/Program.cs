using System;

class Program
{
    // Exceeded requirements by adding a summary report for the listing activity that shows the prompt
    // with the user responses. Also the main program has a summary feed as the user exits which shows
    // how many of each activity the user did, and it automatically changes activities to activity depending on the number.
    static void Main(string[] args)
    {
        ProgressAnimation progress = new ProgressAnimation();
        Activity theActivity = new Activity();
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        int breathingCompleted = 0;
        int reflectingCompleted = 0;
        int listingCompleted = 0;
        int totalActivities = breathingCompleted+reflectingCompleted+listingCompleted;
        
        int choice = 0;
        
        while (choice != 4)
        {
            theActivity.Menu();
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    breathing.RunBreathingActivity();   
                    breathingCompleted++;
                    break;
                case 2:
                    reflecting.RunReflectingActivity();
                    reflectingCompleted++;
                    break;
                case 3:
                    listing.RunListingActivity();
                    listingCompleted++;
                    break;
                case 4:
                    string breathingAct = "Activities";
                    string reflectingAct  = "Activities";
                    string listingAct = "Activities";
                    
                    if (breathingCompleted == 1)
                    {
                        breathingAct = "Activity";
                    }

                    if (reflectingCompleted == 1)
                    {
                        reflectingAct = "Activity";
                    }

                    if (listingCompleted == 1)
                    {
                        listingAct= "Activity";
                    }

                    Console.WriteLine($@"You completed:
                    {breathingCompleted} - Breathing {breathingAct}
                    {reflectingCompleted} - Reflecting {reflectingAct}
                    {listingCompleted} - Listing {listingAct}
                    
                    Grand total of {totalActivities} activities, Well done!");

                    break;
            }
        }
    }   
}
