using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int aTop, int aBottom)
    {
        _top = aTop;
        _bottom = aBottom;
    }

    public string GetFractionString()
    {
        string FractionString = Convert.ToString(_top + "/" + _bottom);
        return FractionString;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }



}
