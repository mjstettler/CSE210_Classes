using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> theShapes = new List<Shape>();
        Square square = new Square(5, "green");
        theShapes.Add(square);
        
        Rectangle rectangle = new Rectangle(5,10, "Yellow");
        theShapes.Add(rectangle);

        Circle circle = new Circle(2.75, "Cyan");
        theShapes.Add(circle);

        foreach (Shape shape in theShapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();
            Type type = shape.GetType();
            Console.WriteLine();
            Console.WriteLine($"The {color} {type} has an area of {area}.");
        }
    }
}