using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _secondVerse = null;
    Scripture scripture;

    public List<Reference> references = new List<Reference>();
    


    public Reference(string aBook, int aChapter, int aVerse, int aSecondVerse, string aScripture)
    {
        _book = aBook;
        _chapter = aChapter;
        _verse = aVerse;
        _secondVerse = aSecondVerse;
        scripture = new Scripture(aScripture);

    }

    public Reference(string aBook, int aChapter, int aVerse, string aScripture)
    {
        _book = aBook;
        _chapter = aChapter;
        _verse = aVerse;
        scripture = new Scripture(aScripture);

    }

    public void Display()
    {
        
        Console.WriteLine($"{_book} {_chapter}:{_verse} {scripture.GetScripture()}");
        
        scripture.RemoveRandomWords();
    }

    public int WordsLeft()
    {
        int wordsLeft = scripture.GetVisibleWordCount();
        return wordsLeft;
    }
}