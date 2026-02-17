using System;

class Search
{
    int[] arr;
    int num;
    
    static void LinearSearch()
    {
        Search array = new Search();
        int[] list = array.arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Search n = new Search();
        int number = n.num = int.Parse(Console.ReadLine());

        int times = 0;

        int i = 0;
        for (; i < list.Length; i++)
        {
            if (list[i] == number)
            {
                times = times + 1;
            }
        }

        Console.Write(times);
    }

    static void Main()
    {
        LinearSearch();
    }
}