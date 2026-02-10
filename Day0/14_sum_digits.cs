using System;

class Sum_Digits
{
    int number;
    
    static void SumDigits()
    {
        Sum_Digits num = new Sum_Digits();
        num.number = int.Parse(Console.ReadLine());

        string str = "" + num.number;
        int sum = 0;

        int i = 0;
        for (; i < str.Length; i++)
        {
            sum = sum + (str[i] - '0');
        }

        Console.Write(sum);
    }

    static void Main()
    {
        SumDigits();
    }
}