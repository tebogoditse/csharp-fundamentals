using System;

class DigitalRoot
{
    public int num;

    static void FindDigitRoot()
    {
        DigitalRoot n = new DigitalRoot();
        n.num = int.Parse(Console.ReadLine());

        int remainder;
        int sum;

        while (n.num >= 10)
        {
            sum = 0;

            while (n.num != 0)
            {
                remainder = n.num % 10;
                sum = sum + remainder;
                n.num = n.num / 10;
            }

            n.num = sum;
            
        }

        Console.Write(n.num);

    }

    static void Main()
    {
        FindDigitRoot();
    }
}