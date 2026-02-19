using System;

class IsPrimeParam
{
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        int i = 2;
        for (; i < n / 2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        bool result = IsPrime(7);

        if (result == true)
        {
            Console.Write("Prime");
        }
        else
        {
            Console.Write("Not Prime");
        }
    }
}