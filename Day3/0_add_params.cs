using System;

class AddParams
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int sum = Add(4, 5);

        Console.Write("Sum: " + sum);
    }
}