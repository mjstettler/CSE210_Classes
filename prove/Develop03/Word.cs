using System;

class Word
{
    private bool _isHidden;
    private string _textValue;
    private int _length;

    public Word(string aWord, int aLength)
    {
        _textValue = aWord;
        _length = aLength;
        _isHidden = false;
        
    }

    public string GetText()
    {
        if (_isHidden)
        {
            // Returns Blank ____ if word is hidden.
            string blank = new string('_',_length);
            _textValue = blank;
            return _textValue;
        }
        return _textValue;
    }

    public string SetText()
    {
        string test1 = _textValue;
        return test1;
    }
}