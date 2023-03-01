using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> theShapes = new List<Shape>();
        Square square = new Square(5);
        square.SetColor("Blue");
        theShapes.Add(square);
        
        Rectangle rectangle = new Rectangle(5,10);
        rectangle.SetColor("Green");
        theShapes.Add(rectangle);

        Circle circle = new Circle(2.75);
        circle.SetColor("Red");
        theShapes.Add(circle);

        foreach (Shape shape in theShapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetType());
            Console.WriteLine();
        }
    }
}