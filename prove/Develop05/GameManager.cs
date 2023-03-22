using System;
using System.Collections.Generic;

public class GameManager
{
    public List<Goal> _goals = new List<Goal>();
    private List<string> _mainMenu = new List<string>();
    private List<FileManager> _fileData;
    private int _totalPoints;
    private string _playerLevel = "Nursery";
    private int _levelScore = 100;
    List<string> _status = new List<string>();
    private int _statusIndex = 0;
    
    

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

        _status.Add("Nursery");
        _status.Add("Sunbeam");
        _status.Add("CTR");
        _status.Add("Valiant");
        _status.Add("Deacon");
        _status.Add("Teacher");
        _status.Add("Priest");
        _status.Add("Elder");
        _status.Add("Missionary");
        _status.Add("Returned Missionary");
        _status.Add("Temple Marriage");
        _status.Add("High Priest");
        _status.Add("Bishop");
        _status.Add("Stake President");
        _status.Add("Area President");
        _status.Add("Quorum of the 70");
        _status.Add("Apostle");
        _status.Add("First Presidency");
        _status.Add("Prophet");
    }
    private string GetPlayerLevel()
    {
        return _playerLevel;
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
        DisplayPlayerProgress();
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
        int choice = 0;
        do
        {
            Console.WriteLine("What kind of Goal do you want to create?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. CheckList Goal");
            Console.Write("-> ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 3 || choice < 1)
            {
                Console.WriteLine("\n\n---Invalid entry, try again.---\n\n");
                Thread.Sleep(1200);
            }
        } while (choice != 1 && choice != 2 && choice != 3);

            string whichType;
            if (choice == 1)
            {
                whichType = "Simple Goal";
                Console.WriteLine($"\nCreating a {whichType}");
            }
            else if (choice == 2)
            {
                whichType = "Eternal Goal";
                Console.WriteLine($"\nCreating an {whichType}");
            }
            else if (choice == 3)
            {
                whichType = "CheckList Goal";
                Console.WriteLine($"\nCreating a {whichType}");
            }


        Console.Write("\nWhat is the Name of your goal?\n-> ");
        string name = Console.ReadLine();

        Console.Write("\nWhat is a short Description of your goal?\n-> ");
        string description = Console.ReadLine();

        Console.Write("\nHow many points is this goal worth?\n-> ");
        int points = Convert.ToInt32(Console.ReadLine());

        return (choice:choice, name:name, description:description, points:points);
        
    }
    
    private void DisplayPlayerProgress()
    {
        Console.WriteLine($"You currently have {_totalPoints} points.\nPlayer Level: {_playerLevel}");
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
                CreateGoal();
                Console.WriteLine("New Goal Created!");
                Thread.Sleep(2000);
                break;
            case LIST:
                ListGoals();
                break;
            case SAVE:
                Save();
                break;
            case LOAD:
                Load();
                Console.ReadKey();
                break;
            case RECORD:
                RecordProgress();
                Console.WriteLine("Goal Progress Recorded!");
                Thread.Sleep(2000);
                break;
            case QUIT:
                Console.Write("\nDo you want to save before quitting? (y/n)\n-> ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Save();
                    break;
                }
                else
                {
                    Console.WriteLine("Remember to come back and log your progress");
                    break;
                }

            default:
                Console.WriteLine("\nSorry that was not an option, try again.\n");
                Thread.Sleep(2000);
                break;
            

        }
        // DisplayPlayerProgress();
        // Thread.Sleep(2000);
        } while (choice != QUIT);
    }

    private void CreateGoal()
    {
        Console.WriteLine();

        var option = GoalMenu();
        
        Goal goal;

        if (option.choice == 1)
        {
            goal = new SimpleGoal(option.name, option.description, option.points);
            _goals.Add(goal);
        }
        else if (option.choice == 2)
        {
            goal = new EternalGoal(option.name, option.description, option.points);
            _goals.Add(goal);
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
        
        
    }
    private void ListGoals()
    {
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.Display());
        }
        Console.WriteLine("\nPress Enter to return to the Main Menu.\n");
        Console.ReadKey();
    }
    private void Save()
    {   
        FileManager file = new FileManager();

        string goalText;
        List<string> goalData = new List<string>();

        Console.Write("What do you want to name the file?\n-> ");
        string fileName = Console.ReadLine()+".txt";

        goalData.Add(Convert.ToString(_totalPoints));

        foreach (Goal goal in _goals)
        {
            string type = Convert.ToString(goal.GetType());
            

            if (type == "CheckListGoal")
            {
                goalText = $"{goal.GetType()},{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetPoints()},{goal.GetCurrentGoalProgress()},{goal.GetRepeatTimes()},{goal.GetisComplete()}"; 
                goalData.Add(goalText);
            }
            else
            {
                goalText = $"{goal.GetType()},{goal.GetGoalName()},{goal.GetGoalDescription()},{goal.GetPoints()},{goal.GetisComplete()}"; 
                goalData.Add(goalText);
            }
            
        }
        file.SaveFile(fileName, goalData);

    }
    public void Load()
    {
        FileManager file = new FileManager();

        

        Console.Write("\nWhat is the filename you want to Load?\n-> ");
        string fileName = Console.ReadLine()+".txt";
        var parts = file.LoadFile(fileName);

        string[] fileData = parts.fileInfo;
        int tPoints = parts.points;
        SetTotalPoints(tPoints);
        

    } 
    private void RecordProgress()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.Display()}");
            i++;
        }

        Console.Write("\nWhich goal do you want to record? ");
        int choice = Convert.ToInt32(Console.ReadLine());
        string choiceType =Convert.ToString(_goals[choice-1].GetType());

        if (_goals[choice-1].GetGoalStatus() == "X")
        {
            Console.WriteLine("Sorry that goal is already completed, try again");
            Thread.Sleep(2000);
        }

        else
        {
            if (choiceType == "SimpleGoal")
            {
                _goals[choice-1].isComplete(true);
                _totalPoints += _goals[choice-1].GetPoints();
                Console.WriteLine($"You have earned {_goals[choice-1].GetPoints()} points!\n");
                Thread.Sleep(2000);
            }
            else if (choiceType == "CheckListGoal")
            {
                _totalPoints += _goals[choice-1].GetPoints();
                Console.WriteLine($"You have earned {_goals[choice-1].GetPoints()} points!\n");
                Thread.Sleep(2000);
            }
            else if (choiceType == "EternalGoal")
            {
                _totalPoints += _goals[choice-1].GetPoints();
                Console.WriteLine($"You have earned {_goals[choice-1].GetPoints()} points!\n");
                Thread.Sleep(2000);
            }
            
            LevelUp();
            DisplayPlayerProgress();
            Thread.Sleep(2000);
        }
    }
    private void SetTotalPoints(int total)
    {
        _totalPoints = total;
    }
    private void LevelUp()
    {
        
        if (_playerLevel == "Prophet")
        {
            Console.WriteLine("You have now joined the city of Enoch! Congrats!");
        }
        else if (_totalPoints >= _levelScore && _totalPoints < _levelScore+200)
        {
            _statusIndex++;
            _playerLevel = _status[_statusIndex];
            
            Thread.Sleep(1500);
            _levelScore += 200;
            Firework fireWorks = new Firework();
            
            fireWorks.DrawFirework();
            Console.WriteLine($"\n---Congrats you have reached status of {GetPlayerLevel()}!!!---\n");
        }
        
    }
}