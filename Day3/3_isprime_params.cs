using System;

class IsPrimeParam
{
    int value;

    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        int i = 2;
        for (; i <= n / 2; i++)
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
        IsPrimeParam num = new IsPrimeParam();

        int n = num.value = int.Parse(Console.ReadLine());

        bool result = IsPrime(n);

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