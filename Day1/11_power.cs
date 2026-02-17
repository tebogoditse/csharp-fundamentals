using System;

class Power
{
    int baseVal, exp;

    static void CalculatePower()
    {
        Power value = new Power();

        int baseValue = value.baseVal = int.Parse(Console.ReadLine());
        int exponent = value.exp = int.Parse(Console.ReadLine());

        int result = (int)Math.Pow(baseValue, exponent);

        Console.Write(result);
    }

    static void Main()
    {
        CalculatePower();
    }
}