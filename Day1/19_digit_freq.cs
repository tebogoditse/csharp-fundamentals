using System;
using System.Linq;
using System.Collections.Generic;

class DigitFrequency
{
    string digit;
    
    static void PrintDigitFrequency()
    {
        List<int> list;

        DigitFrequency n = new DigitFrequency();
        string number = n.digit = Console.ReadLine();

        list = number.Select(c => int.Parse(c.ToString())).ToList();

        var result = list.GroupBy(item => item).ToList();

        int i = 0;
        for (; i < result.Count; i++)
        {
            Console.WriteLine(result[i].Key + " appears " + result[i].Count() + " times");
        }
    }

    static void Main()
    {
        PrintDigitFrequency();
    }
}