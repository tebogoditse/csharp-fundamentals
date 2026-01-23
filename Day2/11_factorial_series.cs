using System;

class FactSeries
{
    public int number;

    static void PrintFactorialSeries()
    {
        FactSeries input = new FactSeries();
        input.number = int.Parse(Console.ReadLine());

        int i = 1;
        int fact = 1;
        for (; i <= input.number; i++)
        {
            fact = fact * i;
            Console.WriteLine(i + "! = " + fact);
        }

    }
    
    static void Main()
    {
        PrintFactorialSeries();
    }
}