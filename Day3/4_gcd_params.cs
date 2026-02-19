using System;
using System.Collections.Generic;

class GcdParams
{
    static int Gcd(int a, int b)
    {
        List<int> list = new List<int>();

        int i = 1;
        for (; i < a || i < b; i++)
        {
            if ((a % i == 0) && (b % i == 0))
            {
                list.Add(i);
            }
        }

        return list[list.Count - 1];
    }

    static void Main()
    {
        int gcd = Gcd(48, 18);

        Console.Write(gcd);
    }
}