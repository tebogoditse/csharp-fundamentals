using System;
using System.Collections.Generic;
using System.Globalization;

public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double r)
    {
        Radius = r;
    }

    public override double Area()
    {
        return Math.PI * (Radius * Radius);
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
        return Height * Width;
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>(); // add Circle/Rectangle and iterate shapes

        string input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            string[] inputs = input.Split(' ');
            string shape = inputs[0].ToLower();
            
            switch (shape)
            {
                case "circle":
                    if (inputs.Length == 2)
                    {
                        double radius = double.Parse(inputs[1], CultureInfo.InvariantCulture);
                        Shape circle = new Circle(radius);

                        shapes.Add(circle);
                    }
                    else
                    {
                        Console.Write("Error! Invalid input");
                    }
                    break;

                case "rectangle":
                    if (inputs.Length == 3)
                    {
                        double width = double.Parse(inputs[1], CultureInfo.InvariantCulture);
                        double height = double.Parse(inputs[2], CultureInfo.InvariantCulture);
                        Shape rectangle = new Rectangle(height, width);

                        shapes.Add(rectangle);
                    }
                    else
                    {
                        Console.Write("Error! Invalid input");
                    }
                    break;

                default:
                    Console.Write("Error! Invalid input");
                    break;
            }
        }

        int i = 0;
        for (; i < shapes.Count; i++)
        {
            if (i == 0)
                Console.WriteLine(shapes[i].Area().ToString("F4", CultureInfo.InvariantCulture));
            else
                Console.WriteLine(shapes[i].Area().ToString(CultureInfo.InvariantCulture));
        }
    }
}