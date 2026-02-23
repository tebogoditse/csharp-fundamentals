using System;
using System.Collections.Generic;

class LcmParams
{
    int n1, n2;

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
        LcmParams num = new LcmParams();

        string[] inputs = Console.ReadLine().Split(' ');

        int a = num.n1 = int.Parse(inputs[0]);
        int b = num.n2 = int.Parse(inputs[1]);

        int result = Lcm(a, b);

        Console.Write(result);
    }
}