using System;

class Program
{
    static void Main(string[] args)
    {
        ProgressAnimation progress = new ProgressAnimation();
        Activity theActivity = new Activity();

        theActivity.Menu();
        progress.DisplayAnimation();
    }
}
