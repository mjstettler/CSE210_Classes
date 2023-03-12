using System;

public class GameManager
{
    private List<Goal> goals = new List<Goal>();
    private List<string> _mainMenu = new List<string>();
    private int _totalPoints;

    private const int CREATE = 1;
    private const int LIST = 2;
    private const int SAVE = 3;
    private const int LOAD = 4;
    private const int RECORD = 5;
    private const int QUIT = 6;
    

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
        foreach (Goal g in goals)
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

    public int GoalMenu()
    {
        Console.WriteLine("What kind of Goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckList Goal");
        Console.Write("-> ");
        int choice = Convert.ToInt32(Console.ReadLine());

        return choice;
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