using System;

class Swap
{
    int num1, num2;

    static void SwapNumbers()
    {
        Swap n = new Swap();

        Console.Write("a = ");
        int a = n.num1 = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = n.num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Before: a=" + a + ", b=" + b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After: a=" + a + ", b=" + b);
    }

    static void Main()
    {
        SwapNumbers();
    }
}