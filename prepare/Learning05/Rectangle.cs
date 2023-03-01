using System;

public class Rectangle : Shape
{
    double _length;
    double _width;

public Rectangle(double aLength, double aWidth, string aColor) : base(aColor)
{
    _length = aLength;
    _width = aWidth;
}
    public override double GetArea()
    {
        return _length*_width;
    }
}