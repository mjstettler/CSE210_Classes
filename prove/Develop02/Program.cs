using System;
using System.Threading;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGen plist = new PromptGen();
        plist.CreateList();
        Entry newEntry = new Entry();

        Console.WriteLine();
        Console.WriteLine("Electronic Journal Recorder");
        Console.WriteLine("Pick an Option from the list Below");

        string selected = "";
        string UserEntry = "";
        string dateText = "";
        string journalPrompt = "";
        while (selected != "Quit")
        {
            
            Console.WriteLine();
            Journal.Menu();
            // foreach (string option in OptionsList)
            // {
                // Console.WriteLine(option);
            // }

            Console.Write("-> ");
            int UserChoice = Convert.ToInt32(Console.ReadLine());

            selected = GetSelection(UserChoice);

            

            if (selected == "Add")
            {
                Console.WriteLine();
                Console.WriteLine("Adding entry to Journal");

                journalPrompt = plist.GetPrompts();
                Console.WriteLine(journalPrompt);
                Console.WriteLine();

                UserEntry = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                dateText = theCurrentTime.ToShortDateString();

                newEntry.SaveArray(dateText, journalPrompt, UserEntry);

                



                Thread.Sleep(1000);
            }
            else if (selected == "Display")
            {
                Console.WriteLine();
                Console.WriteLine("Displaying All Entries");
                newEntry.Display();
                Thread.Sleep(1000);
            }
            else if (selected == "Save")
            {
                Console.WriteLine();
                Console.WriteLine("What is the name of the file?");
                Console.WriteLine("-> ");
                
                string fileName = Console.ReadLine();

                
                Console.WriteLine("Saving File");

                Thread.Sleep(1000);
            }
            else if (selected == "Load")
            {
                Console.WriteLine();
                Console.WriteLine("Loading Journal File");
                Thread.Sleep(1000);
            }
            else if (selected == "Quit")
            {
                Console.WriteLine();
                Console.WriteLine("Exiting the program, Have a Nice Day!");
                Thread.Sleep(1000);
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine($"{selected}. Please Select a Number 1-5.");
                Thread.Sleep(1000);
            }

        

        }



    }

    static string GetSelection(int UserChoice)
    {
        string selected;

        switch (UserChoice)
        {
            case 1:
                selected = "Add";
                break;
            case 2:
                selected = "Display";
                break;
            case 3:
                selected = "Save";
                break;
            case 4:
                selected = "Load";
                break;
            case 5:
                selected = "Quit";
                break;
            default:
                selected = "Invalid Entry";
                break;

        }
        return selected;
    }
}