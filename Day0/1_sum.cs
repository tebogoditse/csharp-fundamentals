using System;

class Sum
{
    int num1;
    int num2;

    public static int CalculateSum()
    {
        Sum sum = new Sum();
        sum.num1 = int.Parse(Console.ReadLine());
        sum.num2 = int.Parse(Console.ReadLine());
        return sum.num1 + sum.num2;
    }
    
    public static void Main()
    {
        Console.WriteLine("Sum: " + CalculateSum());
    }
}