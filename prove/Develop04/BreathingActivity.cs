using System;

class BreathingActivity : Activity
{

    
    
    public BreathingActivity() : base()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    

    }


    public string GetDescription()
    {
        return _description;
    }

    public void RunBreathingActivity()
    {
        base.StartMessage(_activityName);
        Console.WriteLine(_description);
        base.SetDuration();
        int duration = base.GetDuration();
        base.DisplayReadyTimer();
        BreathingTimer(duration);
        base.FinishedMessage(_activityName, duration);
        progress.DisplayAnimation();
    }

    public void BreathingTimer(int aActivityDuration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(aActivityDuration);
        while (DateTime.Now < endTime)
        {

            Console.Write("\nBreath in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.Write("Breath out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        } 
        
    }
}