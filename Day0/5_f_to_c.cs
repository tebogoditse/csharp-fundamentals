using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        float f = 98.6f;

        float c = (f - 32) * 5 / 9;

        Console.Write(c.ToString("F1", CultureInfo.InvariantCulture));
    }
}