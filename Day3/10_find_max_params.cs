using System;

class FindMaxParams
{
    int[] arr;

    static int FindMax(int[] arr)
    {
        int i = 0;
        for (; i < arr.Length - 1; i++)
        {
            int j = 0;
            for (; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    arr[j] = arr[j] + arr[j + 1];
                    arr[j + 1] = arr[j] - arr[j + 1];
                    arr[j] = arr[j] - arr[j + 1];
                }
            }
        }

        return arr[arr.Length - 1];
    }

    static void Main()
    {
        FindMaxParams array = new FindMaxParams();

        int[] arr = array.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int result = FindMax(arr);

        Console.Write(result);
    }
}