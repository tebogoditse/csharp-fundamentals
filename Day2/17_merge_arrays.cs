using System;
using System.Linq;

class Merge
{
    public int[] arr1;
    public int[] arr2;

    static void MergeArrays()
    {
        Merge firstArr = new Merge();
        firstArr.arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Merge secondArr = new Merge();
        secondArr.arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] mergedArr = firstArr.arr1.Concat(secondArr.arr2).ToArray();

        Console.Write(string.Join(" ", mergedArr));

    }

    static void Main()
    {
        MergeArrays();
    }

}