using System;

class Program
{
    static void Factorial()
    {
        int number = int.Parse(Console.ReadLine());

        int fib = 1; 

        while (number > 0)
        {
            fib = fib * number;
            number--;
        }

        Console.Write(fib);
    }

    static void Main()
    {
        Factorial();       
    }
}