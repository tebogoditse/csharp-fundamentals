using System;
using System.Collections.Generic;

class FibNthParams
{
    int arr;

    static int FibNth(int n)
    {
        List<int> list = new List<int> {0, 1};

        if (n < 2)
            return list[n];

        int next;

        int i = 2;
        for (; i <= n; i++)
        {
            next = list[list.Count - 1] + list[list.Count - 2];
            list.Add(next);
        }

        return list[list.Count - 1];
    }

    static void Main()
    {
        FibNthParams array = new FibNthParams();

        int n = array.arr = int.Parse(Console.ReadLine());

        int result = FibNth(n);

        Console.Write(result);
    }
}