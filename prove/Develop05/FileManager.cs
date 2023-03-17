using System;
using System.IO;

public class FileManager
{

    string _fileName;
    List<string> _data = new List<string>();

    public FileManager()
    {
        
    }

    public void SaveFile(string aFileName, List<string> aData)
    {
        Console.WriteLine($"Saving file {aFileName}");

        using (StreamWriter outputFile = new StreamWriter(aFileName))
        {
            foreach (string line in aData)
            {
                outputFile.WriteLine(line);
            }
        }
        Console.WriteLine("File Saved!");
        Thread.Sleep(1500);
        
    }

    public void LoadFile()
    {

    }

}





