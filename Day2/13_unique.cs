using System;
using System.Linq;

class Unique
{
    public int[] originalArr;
    
    static void PrintUniqueElements()
    {
        Unique arr = new Unique();
        arr.originalArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        int[] distinctArr = arr.originalArr.Distinct().ToArray();

        Console.Write(string.Join(" ", distinctArr));
    }

    static void Main()
    {
        PrintUniqueElements();
    }
}