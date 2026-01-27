using System;

class Factorial
{
    public int num;

    static void Fact()
    {
        Factorial input = new Factorial();
        input.num = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (; input.num > 0; input.num--)
        {
            factorial = factorial * input.num;
        }

        Console.Write(factorial);

    }
    
    static void Main()
    {
        Fact();
    }
}