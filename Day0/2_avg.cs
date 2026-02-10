using System;
using System.Globalization;

class Average
{
    float num1;
    float num2;
    float num3;

    public static float CalculateAverage()
    {
        Average avg = new Average();
        avg.num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        avg.num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        avg.num3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float result = (avg.num1 + avg.num2 + avg.num3) / 3;
        return result;
    }
    
    public static void Main()
    {
        Console.WriteLine("Average: " + CalculateAverage().ToString("F2"));
    }
}