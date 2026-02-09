using System;
using System.Linq;

class Max
{
    public int[] arr;

    static void MaxArr()
    {
        Max max_num = new Max();
        max_num.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int i = 0;
        for (; i < max_num.arr.Length - 1; i++)
        {
            int j = 0;
            for (; j < max_num.arr.Length - 1; j++)
            {
                if (max_num.arr[j] < max_num.arr[j + 1])
                {
                    max_num.arr[j] = max_num.arr[j] + max_num.arr[j + 1];
                    max_num.arr[j + 1] = max_num.arr[j] - max_num.arr[j + 1];
                    max_num.arr[j] = max_num.arr[j] - max_num.arr[j + 1];
                }
            }
        }

        Console.Write(string.Join(" ", max_num.arr[0]));
    }

    static void Main()
    {
        MaxArr();
    }
}