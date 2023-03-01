using System;

public abstract class Shape
{
    string _color;

public Shape(string aColor)
{
    _color = aColor;
}
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string aColor)
    {
        _color = aColor;
    }
    public abstract double GetArea();

}