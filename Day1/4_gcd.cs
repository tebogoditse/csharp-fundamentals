using System;
using System.Collections.Generic;

class GCD
{
    int number;

    static void FindGCD()
    {
        List<int> items = new List<int>();

        GCD n = new GCD();

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

        Console.Write(items[items.Count - 1]);
    }

    static void Main()
    {
        FindGCD();
    }

}