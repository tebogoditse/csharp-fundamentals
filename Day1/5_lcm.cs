using System;
using System.Collections.Generic;

class LCM
{
    int number;

    static void FindLCM()
    {
        List<int> items = new List<int>();

        LCM n = new LCM();

        int num1 = n.number = int.Parse(Console.ReadLine());
        int num2 = n.number = int.Parse(Console.ReadLine());

        int i = 1;
        for (; i <= num1 || i <= num2; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                items.Add(i);
            }
        }

        int numerator = num1 * num2;
        int denominator = items[items.Count - 1];

        int lcm = numerator / denominator;

        Console.Write(lcm);
    }

    static void Main()
    {
        FindLCM();
    }
}