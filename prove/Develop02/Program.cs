using System;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Enumeration;

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

                newEntry.StoreArray(dateText, journalPrompt, UserEntry);
                Thread.Sleep(1000); // Time delay for smooth transition 


            }
            else if (selected == "Display")
            {
                Console.WriteLine();
                Console.WriteLine("Displaying All Entries");
                newEntry.Display();
                Thread.Sleep(1000); // Time delay for smooth transition
            }
            else if (selected == "Save")
            {
                Console.WriteLine();
                Console.WriteLine("What is the name of the file?");
                Console.WriteLine("-> ");
                
                string fileName = Console.ReadLine();
                bool isMatch = FileSystemName.MatchesSimpleExpression("*.txt", fileName);

                Console.WriteLine("Saving File");

                if (!isMatch)
                {
                    fileName = fileName + ".txt";
                }
                Console.WriteLine(fileName);
                
                
                

                Console.WriteLine("File Saved!");
                

                Thread.Sleep(1000); // Time delay for smooth transition

            }
            else if (selected == "Load")
            {
                Console.WriteLine();
                Console.WriteLine("Loading Journal File");
                Thread.Sleep(1000); // Time delay for smooth transition
            }
            else if (selected == "Quit")
            {
                Console.WriteLine();
                Console.WriteLine("Exiting the program, Have a Nice Day!");
                Thread.Sleep(1000); // Time delay for smooth transition
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine($"{selected}. Please Select a Number 1-5.");
                Thread.Sleep(1000); // Time delay for smooth transition
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