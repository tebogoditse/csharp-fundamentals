using System;

class SumEven
{
    int[] arr;

    static void SumEvenNumbers()
    {
        SumEven array = new SumEven();
        int[] list = array.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int sum = 0;

        int i = 0;
        for (; i < list.Length; i++)
        {
            if (list[i] % 2 == 0)
            {
                sum = sum + list[i];
            }
        }

        Console.Write(sum);
    }

    static void Main()
    {
        SumEvenNumbers();
    }
}