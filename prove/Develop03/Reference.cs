using System;

class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int? _secondVerse = null;
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

}