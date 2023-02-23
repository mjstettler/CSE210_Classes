using System;

class Program
{
    static void Main(string[] args)
    {
        ProgressAnimation progress = new ProgressAnimation();
        Activity theActivity = new Activity();
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        theActivity.Menu();
        int choice = Int32.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                breathing.RunBreathingActivity();

                

                break;
            case 2:
                theActivity.DisplayReadyTimer();
                break;
            case 3:
                theActivity.DisplayReadyTimer();
                break;
            case 4:
                break;

        }
    }
}
