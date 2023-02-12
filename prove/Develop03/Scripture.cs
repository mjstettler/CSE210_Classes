using System;


class Scripture
{
    List<Word> words;
    string[] verseWords;

    public Scripture(string aScripture)
    {
        verseWords = aScripture.Split(" ");
        words = new Word();

        foreach (string word in verseWords)
        {
            words.Add(new Word(word, word.Length));
        }
    }
}