using System;

class Reference
{
    public string _book {get; set;}
    public int _chapter {get; set;}
    public int _verse {get; set;}
    public int _secondVerse {get; set;}
    public string _scriptureText {get; set;}

    public List<Reference> references = new List<Reference>();
    

    public void DisplayReference()
    {
        
    }

    public Reference(string aBook, int aChapter, int aVerse, int aSecondVerse, string aScriptureText)
    {
        _book = aBook;
        _chapter = aChapter;
        _verse = aVerse;
        _secondVerse = aSecondVerse;
        _scriptureText = aScriptureText;

    }

    public Reference(string aBook, int aChapter, int aVerse, string aScriptureText)
    {
        _book = aBook;
        _chapter = aChapter;
        _verse = aVerse;
        _scriptureText = aScriptureText;
    }

    public Reference()
    {
        references.Add(new Reference("James", 1, 5, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."));
        references.Add(new Reference("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        references.Add(new Reference("Alma", 7, 11, -12, "11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. 12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities."));
    }

    public void Display()
    {
        foreach (Reference reference in references)
        {
            Console.WriteLine($"{reference._book} {reference._chapter}:{reference._verse}{reference._secondVerse} - {reference._scriptureText}");
            Console.WriteLine();
        }
    }
}