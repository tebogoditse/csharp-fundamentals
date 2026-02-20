using System;
using System.Collections.Generic;

class LcmParams
{
    static int Lcm(int a, int b)
    {
        List<int> list = new List<int>();

        int numerator = a * b;

        int i = 1;
        for (; i < a || i < b; i++)
        {
            if ((a % i == 0) && (b % i == 0))
            {
                list.Add(i);
            }
        }

        int denominator = list[list.Count - 1];

        int lcm = numerator / denominator;

        return lcm;
    }

    static void Main()
    {
        int result = Lcm(12, 18);

        Console.Write(result);
    }

}