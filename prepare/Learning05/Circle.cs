using System;

public class Circle : Shape
{
    double _radius;

public Circle(double aRadius, string aColor) : base(aColor)
{
    _radius = aRadius;
}
    public override double GetArea()
    {
        
        return Math.PI*(_radius*_radius);
    }
}