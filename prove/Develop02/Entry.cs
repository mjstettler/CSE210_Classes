using System;
using System.IO;

class Entry
{
    List<string> EntryArray = new List<string>();

    string _date;
    string _prompt;
    string _userEntry;

    public void StoreArray(string aDate, string aPrompt, string aUserEntry)
    {
        
        EntryArray.Add($"Date: {aDate} Prompt: {aPrompt} Entry: {aUserEntry}");
        
    }

    public void Display()
    {
        foreach (string aEntry in EntryArray)
        {
            Console.WriteLine(aEntry);
        }

    }

    public void SaveFile(string aFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(aFileName))
        {
            foreach (string line in EntryArray)
            {
                outputFile.WriteLine(line);
            }
            
        }

    }

    public void LoadFile(string aFileName)
    {
        string[] lines = System.IO.File.ReadAllLines(aFileName);

        foreach (string line in lines)
        {
            EntryArray.Add(line);
            Console.WriteLine("added entry");

            

        }

    }
}




//    public string _prompt;
//    public string _entry;
//    public string _date;
//    public Entry(string aPrompt, string aEntry, string aDate)
//    {
    //    _prompt = aPrompt;
    //    _entry = aEntry;
    //    _date = aDate; 
//    }