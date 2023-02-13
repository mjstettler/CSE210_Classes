using System;


class Scripture
{
    private List<Word> words;
    string[] verseWords;

    public Scripture(string aScripture)
    {
        verseWords = aScripture.Split(" ");
        words = new List<Word>();

        foreach (string word in verseWords)
        {
            words.Add(new Word(word, word.Length));
        }

    }

    public string GetScripture()
    {
        string currentScripture = "";
        
        int listLength = words.Count();
        int loopCount = 0;
        foreach (Word word in words)
        {
            if (loopCount == listLength-1)
            {
                currentScripture += word.GetText();
            }
            else 
            {
                currentScripture += word.GetText() + " ";
            }
            loopCount++;
        }
        return currentScripture;
    }

}