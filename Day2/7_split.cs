using System;

class SplitStr
{
    public string beforeSplit;

    static void SplitAndPrint()
    {
        SplitStr str = new SplitStr();
        str.beforeSplit = Console.ReadLine();

        string[] afterSplit = str.beforeSplit.Split(',');

        int i = 0;
        for (; i < afterSplit.Length; i++)
        {
            Console.Write(afterSplit[i] + '\n');
        }
    }

    static void Main()
    {
        SplitAndPrint();
    }
}