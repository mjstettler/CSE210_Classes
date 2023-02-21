using System;

class Activity
{
    int _activityDuration = 0;
    List<string> randomPrompts = new List<string>();

    public Activity(string aPrompt)
        {
            randomPrompts.Add(aPrompt);
        }
    
    public void GetDuration(int aDuration)
    {
        _activityDuration = aDuration;
    }

    public void StartMessage()
    {

    }

    public void FinishedMessage()
    {

    }

    public void DisplayReadyTimer()
    {
        Console.WriteLine("Get ready");
    }
    
    public void DisplayActivityDescription(string aActivityName)
    {
        Console.WriteLine($"\nWelcome to the {aActivityName} Activity!\n");
    }

    public void Menu()
    {
        Console.WriteLine("\nWelcome to MoM (Mindfulness option Menu)\n");
        Console.WriteLine("1 - Start Breathing Activity");
        Console.WriteLine("2 - Start Reflecting Activity");
        Console.WriteLine("3 - Start Listing Activity");
        Console.WriteLine("4 - Quit\n");
        Console.WriteLine("Please select an option from the menu. (1-4)\n");
    }
}