using System;

class MinArray
{
    public int[] sortArray;

    static void FindMinInArray()
    {
        MinArray arr = new MinArray();
        arr.sortArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int i = 0;
        for (; i < arr.sortArray.Length; i++)
        {
            int j = 0;
            for (; j < arr.sortArray.Length - 1; j++)
            {
                if (arr.sortArray[j] > arr.sortArray[j + 1])
                {
                    arr.sortArray[j] = arr.sortArray[j] + arr.sortArray[j + 1];
                    arr.sortArray[j + 1] = arr.sortArray[j] - arr.sortArray[j + 1];
                    arr.sortArray[j] = arr.sortArray[j] - arr.sortArray[j + 1];
                }
            }
            
        }

        int minInArray = arr.sortArray[0];
        Console.Write(minInArray);
    }

    static void Main()
    {
        FindMinInArray();
    }
}