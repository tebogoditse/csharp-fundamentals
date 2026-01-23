using System;
using System.Linq;

class Reverse
{
    public int[] originalArr;

    static void ReverseArray()
    {
        Reverse arr = new Reverse();
        arr.originalArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] reversed = arr.originalArr.Reverse().ToArray();

        Console.Write(string.Join(" ", reversed));
    }

    static void Main()
    {
        ReverseArray();
    }
}