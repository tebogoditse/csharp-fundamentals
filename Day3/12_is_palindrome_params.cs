using System;

class IsPalindromeParams
{
    string str;

    static bool IsPalindrome(string s)
    {
        string original = s.Trim().Replace(" ", "");
        string reverse = string.Empty;

        int i = original.Length - 1;
        for (; i >= 0; i--)
        {
            reverse = reverse + original[i];
        }

        if (reverse != original)
        {
            return false;
        }

        return true;
    }

    static void Main()
    {
        IsPalindromeParams word = new IsPalindromeParams();

        string s = word.str = Console.ReadLine();

        if (IsPalindrome(s) == true)
        {
            Console.Write("Palindrome");
        }
        else
        {
            Console.Write("Not a palindrome");   
        }
    }
}