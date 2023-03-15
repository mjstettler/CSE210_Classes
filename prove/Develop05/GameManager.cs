using System;

public class GameManager
{
    public List<Goal> _goals = new List<Goal>();
    private List<string> _mainMenu = new List<string>();
    private int _totalPoints;

    private const int CREATE = 1;
    private const int LIST = 2;
    private const int SAVE = 3;
    private const int LOAD = 4;
    private const int RECORD = 5;
    private const int QUIT = 6;
    private const int SIMPLE = 1;
    private const int ETERNAL = 2;
    private const int CHECKLIST =3;
    

    public GameManager()
    {
        _totalPoints = 0;

        _mainMenu.Add("Create New Goal");
        _mainMenu.Add("List All Goals");
        _mainMenu.Add("Save Goals");
        _mainMenu.Add("Load Goals");
        _mainMenu.Add("Record Goal Progress");
        _mainMenu.Add("Quit");
    }

    int i = 1;

    public void ShowGoals()
    {
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{i}. {g.Display()}");
            i++;
        }
    }

    public int MainMenu()
    {
        Console.Clear();
        Console.WriteLine("\nMenu Options:\n");
        int i = 1;

        foreach (string option in _mainMenu)
        {
            Console.WriteLine($"{i}. {option}");
            i++;
        }
        Console.Write("Select an Option from the Menu: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        return choice;
    }

    public (int choice, string name, string description, int points) GoalMenu()
    {
        Console.WriteLine("What kind of Goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("-> ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the Name of your goal?\n-> ");
        string name = Console.ReadLine();

        Console.Write("What is a short Description of your goal?\n-> ");
        string description = Console.ReadLine();

        Console.Write("How many points is this goal worth?\n-> ");
        int points = Convert.ToInt32(Console.ReadLine());

        return (choice:choice, name:name, description:description, points:points);
    }
    
    private void DisplayPlayerProgress()
    {
        Console.WriteLine($"You currently have {_totalPoints} points.");
    }

    public void Start()
    {
        int choice;
        do 
        {
        choice = MainMenu();

        switch (choice)
        {
            case CREATE:
                Console.WriteLine("You are now Creating a goal");
                Console.ReadKey();
                break;
            case LIST:
                Console.WriteLine("You are now Listing your goals");
                Console.ReadKey();
                break;
            case SAVE:
                Console.WriteLine("You are now Saving");
                Console.ReadKey();
                break;
            case LOAD:
                Console.WriteLine("You are now Loading");
                Console.ReadKey();
                break;
            case RECORD:
                Console.WriteLine("You are now Recording");
                Console.ReadKey();
                break;
            

        }
        DisplayPlayerProgress();
        } while (choice != QUIT);
    }

    private void CreateGoal()
    {
        Goal goal;

        var option = GoalMenu();
        
        if (option.choice == 1)
        {
            goal = new SimpleGoal(option.name, option.description, option.points);
        }
        else if (option.choice == 2)
        {
            goal = new EternalGoal(option.name, option.description, option.points);
        }
        else if (option.choice == 3)
        {
            Console.Write("How many times does this goal need to be repeated before marked completed?\n-> ");
            int repeated = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many points does this goal earn when fully completed?\n-> ");
            int completionPoints = Convert.ToInt32(Console.ReadLine());

            goal = new CheckListGoal(option.name, option.description, option.points, repeated, completionPoints);

            _goals.Add(goal);
        }
        else
        {
            Console.WriteLine("Invalid entry! Try again.");
        }
        
        _goals.Add(goal);
    }
private void ListGoals()
{

}
private void Save()
{

}
private void Load()
{

} 
private void RecordProgress()
{
    
}
}