using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        
        SimpleGoal sgoal = new SimpleGoal("Go Running", "Wake up each day and go for a trail run.");
        goals.Add(sgoal);
        SimpleGoal sgoal2 = new SimpleGoal("HI", "Eat less poop");
        goals.Add(sgoal2);
        sgoal2.isComplete(true);

        int i = 1;
        foreach (Goal g in goals)
        {
            Console.WriteLine($"{i}. {g.Display()}");
            i++;
        }

        
    }
}