using System;

class Program
{
    static void EvenOdd()
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.Write("even");
        }
        else
        {
            Console.Write("odd");
        }

    }

    static void Main()
    {
        EvenOdd();
    }
}