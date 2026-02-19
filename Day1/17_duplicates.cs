using System;
using System.Collections.Generic;
using System.Linq;

class Duplicate
{
    int[] array;
    static void FindDuplicates()
    {
        Duplicate arr = new Duplicate();
        int[] list = arr.array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        List<int> duplicates = new List<int>();

        var result = list.GroupBy(item => item).ToList();

        int i = 0;
        for (; i < result.Count; i++)
        {

            if (result[i].Count() > 1)
            {
                duplicates.Add(result[i].Key);
            }
        }

        int elem = 0;
        for (; elem < duplicates.Count; elem++)
        {
            Console.Write(duplicates[elem] + " ");
        }
    }

    static void Main()
    {
        FindDuplicates();
    }
}