using System;

class CountVowelsParam
{
    static int CountVowels(string s)
    {
        int count = 0;

        int i = 0;
        for (; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                count = count + 1;
            }
        }

        return count;
    }

    static void Main()
    {
        int result = CountVowels("Programming");

        Console.Write(result);
    }
}