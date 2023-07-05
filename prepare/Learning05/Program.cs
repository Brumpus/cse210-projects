using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square(5, "blue");
        square.SetColor("Orange");
        shapes.Add(square);
        Circle circle = new Circle(5, "yellow");
        Rectangle rectangle = new Rectangle(5, 10, "blue");
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach(Shape shape in shapes){
            double area = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"{color} {area}");
        }
    }
}