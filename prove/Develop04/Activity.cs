using System;

class Activity
{
    private int _activityDuration = 0; //Time in seconds
    protected string _description;
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    protected DateTime _startTime = DateTime.Now;
    protected ProgressAnimation progress = new ProgressAnimation();
    


    public Activity()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _prompts.Add("Think of a time when you were afraid.");
        _prompts.Add("Think of a time when you felt loved.");
        _prompts.Add("Think of a time when you felt the spirit.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done or felt anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public Activity(string aPrompt, string aQuestion)
        {
            _prompts.Add(aPrompt);
            _questions.Add(aQuestion);
        }

    public string GetRandomPrompt()
    {
        Random r = new Random();
        string prompt = _prompts[r.Next(0,_prompts.Count())];
        return prompt;
    }
    
    public string GetRandomQuestion()
    {
        Random r = new Random();
        string question = _questions[r.Next(0, _questions.Count())];
        return question;
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

    public void FinishedMessage(string aActivityName, int aActivityDuration)
    {
        Console.WriteLine("\nYou did Fantastic!!\n");
        progress.DisplayAnimation();
        Console.WriteLine($"\nCongratulations you have successfully completed {aActivityDuration} seconds of the {aActivityName}.");
        progress.DisplayAnimation();
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