using System;

class Leap
{
    int number;

    static void LeapYearCheck()
    {
        Leap y = new Leap();
        int year = y.number = int.Parse(Console.ReadLine());

        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        {
            Console.Write("Leap year");
        }
        else
        {
            Console.Write("Not a leap year");
        }
    }

    static void Main()
    {
        LeapYearCheck();
    }
}