using System;

class PowerParams
{
    static double Power(double @base, int exponent)
    {
        double result = Math.Pow(@base, exponent);

        return result;
    }

    static void Main()
    {
        double result = Power(2, 8);

        Console.Write(result);
    }
}