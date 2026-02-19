using System;
using System.Collections.Generic;

class FibLimit
{
    int number;

    static void PrintFibonacciUpTo()
    {
        List<int> list = new List<int> {0, 1};

        FibLimit n = new FibLimit();
        int limit = n.number = int.Parse(Console.ReadLine());

        if (limit == 0)
        {
            return;
        }

        int next;

        int i = 2;
        for (; list[list.Count - 1] + list[list.Count - 2] <= limit; i++)
        {
            next = list[list.Count - 1] + list[list.Count - 2];
            list.Add(next);
        }

        int counter = 0;
        for (; counter < list.Count; counter++)
        {
            Console.Write(list[counter] + " ");
        }
    }

    static void Main()
    {
        PrintFibonacciUpTo();
    }
}