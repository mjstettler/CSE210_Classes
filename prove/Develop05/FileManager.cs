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

    public List<string> LoadFile(string aFileName)
    {
        string[] lines = System.IO.File.ReadAllLines(aFileName);

        foreach (string line in lines)
        {
            _data.Add(line);
        }

        return _data;
    }

}





