using System;
using System.Globalization;

class F_to_C
{
    public float fahrenheit;
    
    static string Convert2Celcius()
    {
        F_to_C temparature = new F_to_C();
        temparature.fahrenheit = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float celcius = (temparature.fahrenheit - 32) * (5f / 9f);

        return celcius.ToString("F1" , CultureInfo.InvariantCulture);
    }

    static void Main()
    {
        Console.Write(Convert2Celcius());
    }

}