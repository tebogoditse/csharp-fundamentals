using System;
using System.Collections.Generic;

public interface IRepository<T> 
{ 
    void Add(T item);

    T Get(int index); 
}

public class InMemoryRepository<T> : IRepository<T> 
{ 
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T Get(int index)
    {
        return items[index];
    } 
}

class Program
{
    static void Main()
    {
        IRepository<string> memRepo = new InMemoryRepository<string>();

        string input;
        while((input = Console.ReadLine()) != null && input != "")
        {
            string[] parts;
            if (!input.StartsWith("get "))
            {
                memRepo.Add(input);
            }
            else
            {
                parts = input.Split(' ');
                int index = int.Parse(parts[1]);
                string result = memRepo.Get(index);

                Console.WriteLine(result);
            }
        }
    }
}