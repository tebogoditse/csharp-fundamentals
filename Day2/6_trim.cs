using System;

class TrimStr
{
    public string originalStr;

    static void TrimSpaces()
    {
        TrimStr original = new TrimStr();
        original.originalStr = Console.ReadLine();

        string trimmed = original.originalStr.Trim();

        Console.Write(trimmed);
    }

    static void Main()
    {
        TrimSpaces();
    }
}