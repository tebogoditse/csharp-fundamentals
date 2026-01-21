using System;

class ContainsSub
{
    public string mainString;
    public string subString;

    static void CheckStringContains()
    {
        ContainsSub main = new ContainsSub();
        main.mainString = Console.ReadLine();

        ContainsSub sub = new ContainsSub();
        sub.subString = Console.ReadLine();

        bool containsSubstr = main.mainString.Contains(sub.subString);

        string result = containsSubstr ? "Found" : "Not found";

        Console.Write(result);
    }

    static void Main()
    {
        CheckStringContains();
    }
}