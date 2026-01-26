using System;

class DigitalRoot
{
    static void FindDigitRoot()
    {
        int num = 9;
        int remainder;
        int sum;

        while (num >= 10)
        {
            sum = 0;

            while (num != 0)
            {
                remainder = num % 10;
                sum = sum + remainder;
                num = num / 10;
            }

            num = sum;
            
        }

        Console.Write(num);
        
    }

    static void Main()
    {
        FindDigitRoot();
    }
}