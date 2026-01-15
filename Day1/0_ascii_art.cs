using System;

class AsciiArt
{
    public int size;
    public static void PrintAsciiArt()
    {
        int i = 1;
        AsciiArt n = new AsciiArt();
        n.size = int.Parse(Console.ReadLine());

        for (; i <= n.size; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
    public static void Main()
    {
        PrintAsciiArt();
    }
}