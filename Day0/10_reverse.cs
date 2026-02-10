using System;

class Reverse
{
    string word;

    string ReverseString()
    {
        Reverse str = new Reverse();
        str.word = Console.ReadLine();

        string newWord = string.Empty;

        int i = str.word.Length - 1;
        for (; i >= 0; i--)
        {
            newWord = newWord + str.word[i];
        }

        return newWord;
    }

    static void Main()
    {
        Reverse rev = new Reverse();
        string output = rev.ReverseString();
        Console.Write(output);
    }
}