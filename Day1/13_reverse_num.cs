using System;

class ReverseNum
{
    int num;

    static void ReverseNumber()
    {
        ReverseNum n = new ReverseNum();

        int number = n.num = int.Parse(Console.ReadLine());

        string digit = number.ToString();

        string reverseDigit = string.Empty;

        int i = digit.Length - 1;
        for (; i >= 0; i--)
        {
            reverseDigit = reverseDigit + digit[i];
        }

        Console.Write(reverseDigit);
    }

    static void Main()
    {
        ReverseNumber();
    }
}