using System;
using System.Globalization;

class SimpleInterest
{
    int principal, interest, time;

    static void CalculateSimpleInterest()
    {
        SimpleInterest value = new SimpleInterest(); 

        int p = value.principal = int.Parse(Console.ReadLine());
        int r = value.interest = int.Parse(Console.ReadLine());
        int t = value.time = int.Parse(Console.ReadLine());

        float si = (p * r * t) / 100;

        Console.Write(si.ToString("F2", CultureInfo.InvariantCulture));
    }

    static void Main()
    {
        CalculateSimpleInterest();
    }
}