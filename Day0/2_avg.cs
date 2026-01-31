using System;
using System.Globalization;

class Program
{
    static void Avg()
    {
        float num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        float num3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float average = (num1 + num2 + num3) / 3;
        Console.Write("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
    }
    static void Main()
    {
        Avg();
    }
}