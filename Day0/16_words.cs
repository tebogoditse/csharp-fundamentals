using System;
using System.Text.RegularExpressions;

class Words
{
    string sentence;

    static void CountWords()
    {
        Words str = new Words();
        string word = str.sentence = Console.ReadLine();

        word = Regex.Replace(word, @"\s+", " ").Trim();
        int wordCount = 1;

        int i = 0;
        for (; i < word.Length; i++)
        {
            if (word[i] == ' ')
            {
                wordCount = wordCount + 1;
            }
        }

        Console.Write(wordCount);
    }

    static void Main()
    {
            CountWords();
    }
}