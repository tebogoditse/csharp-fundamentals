using System;

class StringCompare
{
    string first, second;

    static void CompareStrings()
    {
        StringCompare s = new StringCompare();

        string str1 = s.first = Console.ReadLine();
        string str2 = s.second = Console.ReadLine();

        string s1 = str1.ToLower().Trim();
        string s2 = str2.ToLower().Trim();

        if (s1 == s2)
        {
            Console.Write("Strings are equal");
        }
        else
        {
            Console.Write("Strings are not equal");
        }
    }

    static void Main()
    {
        CompareStrings();
    }
}