using System;

class BreathingActivity : Activity
{
    private string _activityName;

    public BreathingActivity()
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
    }

    public void BreathingTimer(int aActivityDuration)
    {
        _startTime = DateTime.Now;
        DateTime endTime = _startTime.AddSeconds(aActivityDuration);
        while (_startTime < endTime)
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