using System;

public class Point 
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point() : this(0, 0) {} 
    
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    } 
    
    public override string ToString()
    {
        string result = "X=" + X + ", Y=" + Y;

        return result;
    }
    
}

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Point point;

        if (!string.IsNullOrWhiteSpace(input))
        {
            string[] inputs = input.Split(' ');

            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);

            point = new Point(x, y);
        }
        else
        {
            point = new Point();
        }

        Console.WriteLine(point);
    }
}