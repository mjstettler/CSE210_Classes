using System;
using System.IO;

class Entry
{
    List<string> EntryArray = new List<string>();

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
            outputFile.WriteLine($"{EntryArray}");
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