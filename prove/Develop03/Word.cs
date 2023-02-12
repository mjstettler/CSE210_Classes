using System;

class Word
{
    bool _isHidden;
    string _textValue;
    int _length;

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
            _textValue = $"_*{_textValue.Length}";
            return _textValue;
        }
        return _textValue;
    }
}