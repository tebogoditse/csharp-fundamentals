using System;

class ReplaceChar
{
    public string originalStr;
    public char oldChar;
    public char newChar;

    static void ReplaceCharacter()
    {
        ReplaceChar str = new ReplaceChar();
        str.originalStr = Console.ReadLine();

        ReplaceChar char1 = new ReplaceChar();
        char1.oldChar = char.Parse(Console.ReadLine());

        ReplaceChar char2 = new ReplaceChar();
        char2.newChar = char.Parse(Console.ReadLine());

        string newString = str.originalStr.Replace(char1.oldChar, char2.newChar);

        Console.Write(newString);
    }

    static void Main()
    {
        ReplaceCharacter();
    }
}