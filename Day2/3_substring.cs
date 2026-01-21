using System;

class Substr
{
    public int startIndex;
    public int endIndex;
    public string str;

    static void ExtractSubstring()
    {
        Substr mainString = new Substr();
        mainString.str = Console.ReadLine();

        Substr start = new Substr();
        start.startIndex = int.Parse(Console.ReadLine());

        Substr end = new Substr();
        end.endIndex = int.Parse(Console.ReadLine());

        string substring = mainString.str.Substring(start.startIndex, end.endIndex);

        Console.Write(substring);
    }

    static void Main()
    {
        ExtractSubstring();
    }
}