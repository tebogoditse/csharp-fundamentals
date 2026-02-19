using System;

class MultiplyParams
{
    static void PrintProduct(int x, int y)
    {
        int product = x * y;

        Console.Write(product);
    }

    static void Main()
    {
        PrintProduct(6, 7);
    }
}