using System;

class ReflectingActivity : Activity
{
    private string _activityName;
    
    
    
    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    
    public void RunReflectingActivity()
    {
        base.StartMessage(_activityName);
        Console.WriteLine(_description);
        base.SetDuration();
        int duration = base.GetDuration();
        
        base.DisplayReadyTimer();
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();

        Console.WriteLine("Ponder upon each of the following questions as they relate to this experience.");

        Console.Write("\nBegin in: ");
        for (int i=5; i<0; i--)
        {
            Console.Write(i);
            Console.Write("\b \b");
        }

        Console.Clear();
        Console.WriteLine($">{GetRandomQuestion()}");
        progress.SecondAnimation(duration/2);
        Console.WriteLine($">{GetRandomQuestion()}");
        progress.SecondAnimation(duration/2);

        
        FinishedMessage(_activityName, duration);





    }

}