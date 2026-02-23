using System;

class MultiplyParams
{
    int num1, num2;

    static void PrintProduct(int x, int y)
    {
        int product = x * y;

        Console.Write(product);
    }

    static void Main()
    {
        MultiplyParams num = new MultiplyParams();

        string[] inputs = Console.ReadLine().Split(' ');

        int x = num.num1 = int.Parse(inputs[0]);
        int y = num.num2 = int.Parse(inputs[1]);

        PrintProduct(x, y);
    }
}