using System;

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        double area = Math.PI * (Radius * Radius);
        return area;
    }
}

public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public override double Area()
    {
        double area = Height * Width;
        return area;
    }
}

public interface IShapeFactory 
{ 
    Shape Create(string kind); 
} 

public class ShapeFactory : IShapeFactory 
{ 
    public Shape Create(string kind)
    {
        string[] input = Console.ReadLine().Split(' ');
        kind = input[0].ToLower();

        if (kind == "circle")
        {
            return new Circle(double.Parse(input[1]));
        }
        else if (kind == "rectangle")
        {
            return new Rectangle(double.Parse(input[1]), double.Parse(input[2]));
        }

        throw new Exception("Invalid Input!");
    } 
}

class Program
{
    static void Main()
    {
        IShapeFactory factory = new ShapeFactory();

        Shape shape = factory.Create("");

        if (shape is Circle)
        {
            Console.WriteLine("Circle area: " + shape.Area().ToString("F4"));
        }
        else if (shape is Rectangle)
        {
            Console.WriteLine("Rectangle area: " + shape.Area());
        }
    }
}