using System;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        // Inta. Prompt generator class
        PromptGen plist = new PromptGen(); 

        // Creating the list of possible writing prompts
        plist.CreateList(); 

        // Inta. Entry class
        Entry newEntry = new Entry();

        Console.WriteLine();
        Console.WriteLine("Electronic Journal Recorder");
        Console.WriteLine("Pick an Option from the list Below");

        // Variables for entry loop
        string selected = "";
        string UserEntry = "";
        string dateText = "";
        string journalPrompt = "";
        while (selected != "Quit")
        {
            // Spacing for white space and readability 
            Console.WriteLine();

            // Journal program options menu
            Journal.Menu();
            Console.Write("-> ");
            int UserChoice = Convert.ToInt32(Console.ReadLine());

            // Confusion Variable that uses a switch and sends info to if statement....Pointless use of both switch and if statement
            selected = GetSelection(UserChoice);

            

            if (selected == "Add")
            {
                Console.WriteLine();
                Console.WriteLine("Adding entry to Journal");

                // Picking a Random writing prompt and printing to the console
                journalPrompt = plist.GetPrompts();
                Console.WriteLine(journalPrompt);
                Console.WriteLine();

                UserEntry = Console.ReadLine();

                // Getting the current date for the entry
                DateTime theCurrentTime = DateTime.Now;
                dateText = theCurrentTime.ToShortDateString();

                // Saving date, prompt, and user response to array inside Entry class
                newEntry.StoreArray(dateText, journalPrompt, UserEntry);
                Thread.Sleep(1000); // Time delay for smooth transition 


            }

            else if (selected == "Display")
            {
                Console.WriteLine();
                Console.WriteLine("Displaying All Entries");

                // Displays all recorded entries back to the console for user to read.
                newEntry.Display();
                Thread.Sleep(1000); // Time delay for smooth transition
            }

            else if (selected == "Save")
            {
                Console.WriteLine();
                Console.WriteLine("What is the name of the file?");
                Console.WriteLine("-> ");

                // User picked filename
                string fileName = Console.ReadLine();

                // Looks to see if the file name has the .txt extension
                bool isMatch = FileSystemName.MatchesSimpleExpression("*.txt", fileName);

                Console.WriteLine("Saving File");

                if (!isMatch) // adds .txt file extension if missing
                {
                    fileName = fileName + ".txt";
                }

                

                // Saving all user entered entries from saved array to a txt file
                newEntry.SaveFile(fileName);

                Console.WriteLine("File Saved!");
                

                Thread.Sleep(1000); // Time delay for smooth transition

            }
            else if (selected == "Load")
            {
                Console.WriteLine();

                // Getting file name to load 
                Console.WriteLine("What is the name of the file?");
                Console.Write("-> ");

                string fileName = Console.ReadLine();

                // White space
                Console.WriteLine();

                // Looks to see if the file name has the .txt extension
                bool isMatch = FileSystemName.MatchesSimpleExpression("*.txt", fileName);
                Console.WriteLine("Loading Journal File");

                if (!isMatch) // adds .txt file extension if missing
                {
                    fileName = fileName + ".txt";
                }
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