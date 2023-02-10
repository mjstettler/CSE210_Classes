using System;

class Words
{
    List<string> ScriptureWords = new List<string>();
    List<string> HiddenWords = new List<string>();







    public void ShowScripture(string reference)
    {
        foreach (string word in ScriptureWords)
        {
            Console.Write($"{word} ");

        }
    }
}