using System;

class Vowels
{
    string word;

    static void CountVowels()
    {
        Vowels str = new Vowels();
        string w = str.word = Console.ReadLine();

        int count = 0;

        int i = 0;
        for (; i < w.Length; i++)
        {
            if (w[i] == 'a' || w[i] == 'e' || w[i] == 'i' || w[i] == 'o' || w[i] == 'u')
            {
                count = count + 1;
            }
        }

        Console.Write(count);
    }

    static void Main()
    {
        CountVowels();
    }
}