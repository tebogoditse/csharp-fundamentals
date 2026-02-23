using System;
using System.Collections.Generic;

class GcdParams
{
    int n1, n2;

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
        GcdParams num = new GcdParams();

        string[] inputs = Console.ReadLine().Split(' ');

        int a = num.n1 = int.Parse(inputs[0]);
        int b = num.n2 = int.Parse(inputs[1]);

        int gcd = Gcd(a, b);

        Console.Write(gcd);
    }
}