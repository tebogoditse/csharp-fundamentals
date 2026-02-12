using System;
using System.Globalization;

class ArrayAverage
{
    int[] array;

    static void CalculateArrayStats()
    {
        ArrayAverage arr = new ArrayAverage();
        arr.array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);;

        int sum = 0;

        int i = 0;
        for (; i < arr.array.Length; i++)
        {
            sum = sum + arr.array[i];
        }

        float average = sum / arr.array.Length;
        
        Console.WriteLine("Sum: " + sum);
        Console.Write("Average: " + average.ToString("F2", CultureInfo.InvariantCulture));
    }

    static void Main()
    {
        CalculateArrayStats();
    }
}