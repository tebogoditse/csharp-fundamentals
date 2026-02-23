using System;

class SumArrayParams
{
    int[] arr;

    static int SumArray(int[] values)
    {
        int sum = 0;

        int i = 0;
        for (; i < values.Length; i++)
        {
            sum = sum + values[i];
        }

        return sum;
    }

    static void Main()
    {
        SumArrayParams array = new SumArrayParams();

        int[] values = array.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int result = SumArray(values);

        Console.Write(result);
    }
}