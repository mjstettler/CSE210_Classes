using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Garmin";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Developer";
        job2._company = "Github";
        job2._startYear = 1991;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Mike Stettler";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}