using System;
using System.Collections.Generic;

class Fibonacci
{
    public int number;

    static void Fib()
    {
        List<int> numbers = new List<int>();

        numbers.Add(0);
        numbers.Add(1);

        Fibonacci end = new Fibonacci();
        end.number = int.Parse(Console.ReadLine());

        if (end.number < 2)
            return;

        int i = 2;
        for (; i < end.number; i++)
        {
            int next = numbers[numbers.Count - 1] + numbers[numbers.Count - 2];
            numbers.Add(next);
        }

        int count = 0;
        for (; count < numbers.Count; count++)
        {
            Console.Write(numbers[count] + " ");
        }

    }

    static void Main()
    {
        Fib();
    }
}