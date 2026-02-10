using System;

class Multiplication
{
    int number;

    static void Mult_Table()
    {
        Multiplication n = new Multiplication();
        int num = n.number = int.Parse(Console.ReadLine());
        
        int res;

        int i = 1;
        for (; i <= 10; i++)
        {
            res = num * i;
            Console.WriteLine(num + " x " + i + " = " + res);
        }
    }

    static void Main()
    {
        Mult_Table();
    }
}