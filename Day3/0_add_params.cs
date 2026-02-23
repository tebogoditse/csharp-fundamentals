using System;

class AddParams
{
    int num1, num2;

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        AddParams num = new AddParams();

        string[] inputs = Console.ReadLine().Split(' ');

        int a = num.num1 = int.Parse(inputs[0]);
        int b = num.num2 = int.Parse(inputs[1]);

        int sum = Add(a, b);

        Console.Write("Sum: " + sum);
    }
}