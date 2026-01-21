using System;

class CharIndex
{
    public string str;
    public int charIndex;

    static void GetCharacterAtIndex()
    {
        CharIndex getString = new CharIndex();
        getString.str = Console.ReadLine();

        CharIndex getIndex = new CharIndex();
        getIndex.charIndex = int.Parse(Console.ReadLine());

        Console.Write(getString.str[getIndex.charIndex]);
    }
    static void Main()
    {
        GetCharacterAtIndex();
    }
}