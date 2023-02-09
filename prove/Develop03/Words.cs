using System;

class Words
{

    List<string> WordList = new List<string>();

    List<string> HiddenWords = new List<string>();

    public Words(string aWord)
    {
        HiddenWords.Add(aWord);
    }

    public void ShowScripture()
    {
        foreach (string word in WordList)
        {
            Console.Write($"{word} ");
        }
    }
}
