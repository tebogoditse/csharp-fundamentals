using System;

class Program
{
    static void Sum()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        Console.Write(sum);

    }
        
    static void Main()
    {
        Sum();
    }

}