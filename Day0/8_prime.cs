using System;

class Prime
{
    public int number;
    
    static bool isPrime()
    {
        Prime check = new Prime();
        check.number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (check.number < 2)
        {
            isPrime = false;
        }

        int i = 2;
        for (; i <= check.number / 2; i++)
        {
            if (check.number % i == 0)
            {
                isPrime =  false;
            }
        }

        return isPrime;
    }

    static void Main()
    {
        Console.Write(isPrime() ? "Prime" : "Not Prime");
    }
}