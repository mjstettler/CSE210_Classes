using System;


class Scripture
{
    private List<Word> words;
    private string[] verseWords;

    public Scripture(string aScripture)
    {
        verseWords = aScripture.Split(" ");
        words = new List<Word>();

        foreach (string word in verseWords)
        {
            words.Add(new Word(word, word.Length));
        }
    }
}