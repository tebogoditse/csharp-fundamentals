using System;

class EvenOdd
{
    public int number;

    public static string EvenOrOdd()
    {
        EvenOdd num = new EvenOdd();
        num.number = int.Parse(Console.ReadLine());
        if (num.number % 2 == 0)
            return "Even";
        else
            return "Odd";
    }
    public static void Main()
    {
        Console.WriteLine(EvenOrOdd());
    }
}