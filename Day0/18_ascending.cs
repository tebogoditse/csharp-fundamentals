using System;
using System.Linq;

class Ascending
{
    int[] arr;

    static string IsAscending()
    {
        Ascending check = new Ascending();
        int[] array = check.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int i = 0;
        for (; i < array.Length - 1; i++)
        {
            int j = 0;
            for (; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    return "Not Ascending";
                }
            }
        }

        return "Ascending";
    }

    static void Main()
    {
        string result = IsAscending();
        Console.Write(result);
    }
}