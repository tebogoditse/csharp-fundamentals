using System;

class OddCount
{
    public int[] arr;

    static void CountOddNumbers()
    {
        OddCount countOdd = new OddCount();
        countOdd.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    
        int count = 0;

        int i = 0;
        for (; i < countOdd.arr.Length; i++)
        {
            if (countOdd.arr[i] % 2 == 0)
            {
                count = count + 1;
            }
        }

        Console.Write(count);
    }

    static void Main()
    {
        CountOddNumbers();
    }
}