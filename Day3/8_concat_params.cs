using System;

class ConcatParams
{
    string input, splitter;

    static string JoinWith(string[] parts, string sep)
    {
        string newString = string.Join(sep, parts);

        return newString;
    }

    static void Main()
    {
        ConcatParams s = new ConcatParams();

        string inputStr = s.input = Console.ReadLine();
        string sep = s.splitter = Console.ReadLine();

        string[] parts = inputStr.Split(',');

        string result = JoinWith(parts, sep);

        Console.Write(result);
    }
}