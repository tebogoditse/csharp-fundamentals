using System;

class NestedPattern
{
    public int size;
    
    static void PrintNestedPattern()
    {
        NestedPattern n = new NestedPattern();
        n.size = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n.size; row++)
        {
            for (int col = 1; col <= n.size; col++)
            {
                Console.Write(row);
                Console.Write(' ');
            }
            Console.Write('\n');
        }
    }

    static void Main()
    {
        PrintNestedPattern();
    }
}