using System;

class ReverseParam
{
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
        string result = Reverse("Tebogo");

        Console.Write(result);
    }
}