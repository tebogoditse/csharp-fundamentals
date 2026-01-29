using System;
using System.Globalization;

class F_to_C
{
    static string Convert2Celcius()
    {
        float fahrenheit = 98.6F;

        float celcius = (fahrenheit - 32) * (5f / 9f);

        return celcius.ToString("F1" , CultureInfo.InvariantCulture);
    }

    static void Main()
    {
        Console.Write(Convert2Celcius());
    }

}