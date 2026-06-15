using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Circle("red", 5));
        shapes.Add(new Square("blue", 10));
        shapes.Add(new Rectangle("green", 5, 10));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}: {shape.GetArea()}\n");
        }
    }
}