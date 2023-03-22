using System;
using System.IO;

public class FileManager
{
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

    public (string[] fileInfo, int points) LoadFile(string aFileName)
    {
        string[] lines = System.IO.File.ReadAllLines(aFileName);
        Console.WriteLine(lines[0]);
        int points = Convert.ToInt32(lines[0]);

        Console.WriteLine(lines[1]);

        int length = lines.Count();
        string[] _data = new string[length];

        int i = 0;
        foreach (string line in lines)
        {
            _data[i] = line.Split(",").ToString();
            i++;
            if (_data[1] == "CheckListGoal")
            {
                Console.WriteLine("Yep this is a checklist goal");
            }
            else if (_data[1] == "SimpleGoal")
            {
                Console.WriteLine("This is not a Check List, it is simple");
            }
        }
        foreach (string str in _data)
        {
            Console.WriteLine(str);
        }
        Console.WriteLine(_data[1]);

        if (_data[0] == "CheckListGoal")
        {
            Console.WriteLine("Yep this is a checklist goal");
        }
        
        return (fileInfo:_data, points:points);
    }

}





