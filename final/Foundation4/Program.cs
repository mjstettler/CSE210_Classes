using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Activity> exercises = new List<Activity>();
        string today;
        today = DateTime.Now.ToString("dd MMMM yyyy");
        Running run;
        Cycling bike;
        Swimming swim;

        
        exercises.Add(run = new Running(today, 90, 8.02));
        exercises.Add(bike = new Cycling(today, 120, 19.0));
        exercises.Add(swim = new Swimming(today, 30, 60));

        foreach (Activity active in exercises)
        {
            active.GetSummary();
        }
        


    }
}