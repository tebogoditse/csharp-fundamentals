using System;
using System.Collections.Generic;

class Armstrong
{
    int num;

    static void CheckArmstrong()
    {
        List<int> list = new List<int>();

        Armstrong n = new Armstrong();
        int number = n.num = int.Parse(Console.ReadLine());

        int originalNumber = number;

        while (number > 0)
        {
            list.Add((int)Math.Pow(number % 10, 3));
            number = number / 10;
        }

        int listSum = 0;
        int i = 0;
        for (; i < list.Count; i++)
        {
            listSum = listSum + list[i];
        }

        if (listSum == originalNumber)
        {
            Console.Write("Armstrong number");
        }
        else
        {
            Console.Write("Not an Armstrong number");
        }
    }

    static void Main()
    {
        CheckArmstrong();
    }
}