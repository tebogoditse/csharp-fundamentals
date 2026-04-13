using System;

public class Counter 
{ 
    private int value; 
    
    public Counter(int start)
    {
        value = start;
    } 
    
    public void Increment()
    {
        value = value + 1;
    } 
    
    public void Decrement()
    {
        value = value - 1;
    } 
    
    public int Get()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        Counter start = new Counter(startValue);

        string input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            if (input == "increment")
            {
                start.Increment();
            }
            else if (input == "decrement")
            {
                start.Decrement();
            }
            else if (input == "get")
            {
                Console.WriteLine(start.Get());
                break;
            }
            else
            {
                Console.WriteLine("Invalid input!!! Try Again.");
            }
        }
    }
}