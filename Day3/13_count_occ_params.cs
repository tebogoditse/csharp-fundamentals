using System;

class CountOccParams
{
    string str;
    char chr;

    static int CountOccurrences(string s, char c)
    {
        int count = 0;

        int i = 0;
        for (; i < s.Length; i++)
        {
            if (c == s[i])
            {
                count = count + 1;
            }
        }

        return count;
    }

    static void Main()
    {
        CountOccParams word = new CountOccParams();
        string s = word.str = Console.ReadLine();

        CountOccParams character = new CountOccParams();
        char c = character.chr = char.Parse(Console.ReadLine());

        int result = CountOccurrences(s, c);

        Console.Write(result);
    }
}