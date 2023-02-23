using System;

class Activity
{
    private int _activityDuration = 0; //Time in seconds
    protected string _description;
    private List<string> randomPrompts = new List<string>();
    protected DateTime _startTime = DateTime.Now;
    


    public Activity()
    {

    }

    public Activity(string aPrompt)
        {
            randomPrompts.Add(aPrompt);
        }
    

    public void SetDuration()
    {
        Console.WriteLine("\nHow long would you like to do this activity in seconds? ");
        Console.Write("-->");
        int seconds = Int32.Parse(Console.ReadLine());

        _activityDuration = seconds;
    }

    public int GetDuration()
    {
        return _activityDuration;
    }

    public void StartMessage(string aActivityName)
    {
        Console.WriteLine($"\nWelcome to the {aActivityName}.\n");
    }

    public void FinishedMessage(string aActivityName)
    {
        Console.WriteLine("Congratulations you have successfully completed the {aActivityName}.");
    }

    public void DisplayReadyTimer()
    {
        Console.CursorVisible = false;
        Console.Write("\nGet ready ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($".{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write(" Start\n");
        Console.CursorVisible = true;
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
        Console.Write("-->");
        
    }
}