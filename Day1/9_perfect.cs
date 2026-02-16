using System;

class PerfectNum
{
    int num;

    static void CheckPerfectNumber()
    {
        PerfectNum n = new PerfectNum();
        int number = n.num = int.Parse(Console.ReadLine());

        int sumOfFactors = 0;

        int i = 1;
        for (; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfFactors = sumOfFactors + i;
            }
        }

        if (number == sumOfFactors)
        {
            Console.Write("Perfect number");
        }
        else
        {
            Console.Write("Not a Perfect number");
        }
    }

    static void Main()
    {
        CheckPerfectNumber();
    }
}