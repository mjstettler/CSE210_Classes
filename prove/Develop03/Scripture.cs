using System;


class Scripture
{
    private List<Word> words;
    private List<int> wordIndexes;
    string[] verseWords;

    public Scripture(string aScripture)
    {
        verseWords = aScripture.Split(" ");
        words = new List<Word>();
        wordIndexes = new List<int>();
        int loopCount = 0;

        foreach (string word in verseWords)
        {
            words.Add(new Word(word, word.Length));
            wordIndexes.Add(loopCount);
            loopCount++;
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

    public void RemoveRandomWords()
    {
        int indexNum;
        Random Num = new Random();
        for (int i = 0; i<3; i++)
        {
            if (wordIndexes.Count() > 0)
                {
                // Console.WriteLine(wordIndexes.Count());
                indexNum = Num.Next(0, wordIndexes.Count()-1);
                words[wordIndexes[indexNum]].HideWord();
                wordIndexes.RemoveAt(indexNum);
                
                
                }
            else 
            {
                break;
            }
        }
    }

    public int GetVisibleWordCount()
    {   
        int count = wordIndexes.Count();
        return count;
    }

}