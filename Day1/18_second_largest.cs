using System;

class SecondLargest
{
    int[] array;
    
    static void FindSecondLargest()
    {
        SecondLargest arr = new SecondLargest();
        int[] list = arr.array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

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

        Console.Write(list[list.Length - 2]);
    }

    static void Main()
    {
        FindSecondLargest();
    }
}