using System;

class SumOdd
{
    public int[] arr;

    static void SumOddNumbers()
    {
        SumOdd countOdd = new SumOdd();
        countOdd.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    
        int oddSum = 0;

        int i = 0;
        for (; i < countOdd.arr.Length; i++)
        {
            if (countOdd.arr[i] % 2 != 0)
            {
                oddSum = oddSum  + countOdd.arr[i];
            }
        }

        Console.Write(oddSum);
    }

    static void Main()
    {
        SumOddNumbers();
    }
}