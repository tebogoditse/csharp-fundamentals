using System;
using System.Linq;

class Palindrome
{
    public string word;

    static string PalindromeCheck()
    {
        Palindrome check = new Palindrome();
        check.word = Console.ReadLine();

        string newWord = check.word.Replace(" ", string.Empty).ToLower();

        string reverse = string.Empty;

        for (int i = newWord.Length - 1; i >= 0; i--)
        {
            reverse = reverse + newWord[i];
        }

        if (reverse == newWord)
        {
            return "Palindrome";
        }

        return "Not a palindrome";
        
    }
    static void Main()
    {
        string result = PalindromeCheck();

        Console.Write(result);
        
    }
}