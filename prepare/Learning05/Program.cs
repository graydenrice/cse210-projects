using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> _shapes = new List<Shape>(){
        };


        Square square = new Square("red", 6);
        _shapes.Add(square);

        Rectangle rectangle = new Rectangle(3, 6, "blue");
        _shapes.Add(rectangle);

        Circle circle = new Circle("green", 4);
        _shapes.Add(circle);

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
        
    }
}