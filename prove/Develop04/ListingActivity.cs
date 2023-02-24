using System;

class ListingActivity : Activity
{
    int _listCount;
    string _activityExplanation;

    List<string> _userInput = new List<string>();
    List<string> _listingPrompts = new List<string>();
    
    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _activityExplanation = "\nList as many responses you can to the following prompt:\n";
        _listingPrompts.Add("Who are people that you appreciate?");
        _listingPrompts.Add("What are personal strengths of yours?");
        _listingPrompts.Add("Who are people that you have helped this week?");
        _listingPrompts.Add("When have you felt the Holy Ghost this month?");
        _listingPrompts.Add("Who are some of your personal heroes?");
        _listingPrompts.Add("What make you feel happy and alive?");
        _listingPrompts.Add("If I only had one year left to live, how would I spend it?");
        _listingPrompts.Add("What are your weaknesses you want to improve?");

    }

    public void RunListingActivity()
    {
        string prompt = GetRandomPrompt();
        StartMessage(_activityName);
        Console.WriteLine(_description);
        SetDuration();
        int duration = GetDuration();
        Console.WriteLine(_activityExplanation);
        
        DisplayReadyTimer();
        
    }


    public string GetListingPrompt()
    {
        Random r = new Random();
        string prompt = _listingPrompts[r.Next(0,_listingPrompts.Count())];
        return prompt;
    }
}