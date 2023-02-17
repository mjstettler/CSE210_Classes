using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _secondVerse = null;
    Scripture _scripture;

    public List<Reference> references = new List<Reference>();
    


    public Reference(string aBook, int aChapter, int aVerse, int aSecondVerse, string aScripture)
    {
        _book = aBook;
        _chapter = aChapter;
        _verse = aVerse;
        _secondVerse = aSecondVerse;
        _scripture = new Scripture(aScripture);

    }

    public Reference(string aBook, int aChapter, int aVerse, string aScripture)
    {
        _book = aBook;
        _chapter = aChapter;
        _verse = aVerse;
        _scripture = new Scripture(aScripture);

    }

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}{_secondVerse} {_scripture.GetScripture()}");
        
        _scripture.RemoveRandomWords();
    }

    public int WordsLeft()
    {
        int wordsLeft = _scripture.GetVisibleWordCount();
        return wordsLeft;
    }
}