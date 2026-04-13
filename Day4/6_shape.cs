using System;
using System.Globalization;

public abstract class Shape 
{ 
    public abstract double Area(); 
} 

public class Circle : Shape 
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    } 
    
    public override double Area()
    {
        double area = Math.PI * radius * radius;

        return area;
    } 
}

public class Rectangle : Shape 
{
    private double width, height;

    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    } 
    
    public override double Area()
    {
        double area = width * height;

        return area;
    } 
}

class Program
{
    static void Main()
    {
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
                        Circle circle = new Circle(radius);

                        Console.WriteLine("Circle area: " + circle.Area().ToString("F4", CultureInfo.InvariantCulture));
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
                        Rectangle rectangle = new Rectangle(width, height);

                        Console.WriteLine("Rectangle area: " + rectangle.Area());
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
    }
}