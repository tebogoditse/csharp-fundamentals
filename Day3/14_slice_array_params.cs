using System;
using System.Collections.Generic;

class SliceArrParams
{
    int[] arr;
    int beginning, ending;

    static int[] Slice(int[] array, int start, int length)
    {
        List<int> list = new List<int>();

        int i = start;
        int end = start + length;
        for (; i < end; i++)
        {
            list.Add(array[i]);
        }

        return list.ToArray();
    }

    static void Main()
    {
        SliceArrParams list = new SliceArrParams();
        int[] array = list.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        SliceArrParams elem = new SliceArrParams();
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int start = elem.beginning = inputs[0];
        int length = elem.ending = inputs[1];

        int[] result = Slice(array, start, length);

        int i = 0;
        for(; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}