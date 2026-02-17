using System;

class Sort
{
    int[] arr;

    static void BubbleSort()
    {
        Sort array = new Sort();
    
        int[] list = array.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int i = 0;
        for (; i < list.Length - 1; i++)
        {
            int j = 0;
            for (; j < list.Length - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    list[j] = list[j] + list[j + 1];
                    list[j + 1] = list[j] - list[j + 1];
                    list[j] = list[j] - list[j + 1];
                }
            }
        }

        Console.Write(string.Join(" ", list));
    }

    static void Main()
    {
        BubbleSort();
    }
}