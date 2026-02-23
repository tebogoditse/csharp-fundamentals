using System;

class ReverseParam
{
    string str;

    static string Reverse(string s)
    {
        string newString = s.Trim();
        
        string reverseString = string.Empty;

        int i = newString.Length - 1;
        for (; i >= 0; i--)
        {
            reverseString = reverseString + newString[i];
        }

        return reverseString;
    }

    static void Main()
    {
        ReverseParam word = new ReverseParam();

        string s = word.str = Console.ReadLine();

        string result = Reverse(s);

        Console.Write(result);
    }
}