using System;

class Digit
{
    int number;
    
    static void DigitCount()
    {
        Digit count = new Digit();
        count.number = int.Parse(Console.ReadLine());

        string digits = "" + count.number;

        Console.Write(digits.Length);
    }

    static void Main()
    {
        DigitCount();
    }
}