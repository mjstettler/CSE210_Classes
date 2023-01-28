using System;

class PromptGen
{
    public List<string> PromptList = new List<string>();
    
    
    
    public string GetPrompts()
    {
        Random randomGenerator = new Random();
        int PromptNum = randomGenerator.Next(0, (PromptList.Count));
        string prompt = PromptList[PromptNum];
        
        return prompt;
    }

    public void CreateList()
    {
        

        PromptList.Add("What kind of day are you having and why?");
        PromptList.Add("What's your favorite color, place, food, book, song, or movie, and why?");
        PromptList.Add("What do you like to do? How does it make you feel?");
        PromptList.Add("Where are you happiest? Describe that place");
        PromptList.Add("What's something you're good at? What makes you good at it?");
        PromptList.Add("What was your greatest fear, and how did you conquer it?");
        PromptList.Add("What is something that you would like to change about yourself? How can you change it?");
        PromptList.Add("If you are granted a wish, what would you wish for and why?");
        PromptList.Add("Where’s one place that you’d like to visit, and how do you imagine your time there?");
        PromptList.Add("If you are a superhero, what superpower would you like to have and how would you use it?");
        PromptList.Add("Write about the people around you to describe what they are like, and what are your views about their actions etc.");
        PromptList.Add("What is something that you would like to achieve? How do you plan on reaching your goal(s)?");
        PromptList.Add("How could you make someone you care about feel better if he/she just lost something important to them?");
        PromptList.Add("If you could invent anything, what would it be? Describe why you want to invent it, what it would look like, what it would do, etc.");
        PromptList.Add("Choose the animals that best represent your family members and closest friends. Explain why you have chosen each animal. ");
        PromptList.Add("What if the world was made of Jello?");
        PromptList.Add("If your life was suddenly a hit reality television show, what would it be called and what would viewers say about it? ");
        PromptList.Add("Describe your survival plan in the event of a zombie apocalypse. ");
        PromptList.Add("Explain what a forest looks like to someone who cannot see. ");
        PromptList.Add("If you woke up tomorrow with amnesia, what memories would you want to return? To forget forever?");
        PromptList.Add("What are you most thankful for?");
        PromptList.Add("Do you think the past is the best predictor of your future? Why or why not?");
        PromptList.Add("How have you changed from when you were a child? Why?");
        PromptList.Add("Which is better: too much of something or too little of something?");
        PromptList.Add("Is social media a blessing or a curse? ");
        PromptList.Add("What labels could others give you? Are labels helpful or harmful? Explain.");
        PromptList.Add("Is society today better off than it was 100 years ago?");
        Console.WriteLine(PromptList.Count);

    }






    // public string RandomPrompt()
    // {
        // Console.WriteLine();
        // Random randomGenerator = new Random();
        // int PromptNum = randomGenerator.Next(0, (prompts.Count));
        // string prompt = prompts[PromptNum];
        // return prompt;
    // }
}