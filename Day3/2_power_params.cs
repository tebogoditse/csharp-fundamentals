using System;

class PowerParams
{
    int num1, num2;

    static double Power(double @base, int exponent)
    {
        double result = Math.Pow(@base, exponent);

        return result;
    }

    static void Main()
    {
        PowerParams num = new PowerParams();

        int @base = num.num1 = int.Parse(Console.ReadLine());
        int exponent = num.num2 = int.Parse(Console.ReadLine());

        double result = Power(@base, exponent);

        Console.Write(result);
    }
}