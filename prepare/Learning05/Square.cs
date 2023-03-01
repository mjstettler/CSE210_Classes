using System;

public class Square : Shape
{
    private double _side;

public Square(double aSide, string aColor) : base(aColor)
{
    _side = aSide;
    
}
    public override double GetArea()
    {
        return _side * _side;
    }
}