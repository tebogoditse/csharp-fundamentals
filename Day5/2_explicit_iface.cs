using System;

public interface IA 
{ 
    void Do(); 
} 

public interface IB 
{ 
    void Do(); 
}

public class Dual : IA, IB 
{ 
    void IA.Do()
    {
        Console.WriteLine("IA.Do called");
    }
    
    void IB.Do()
    {
        Console.WriteLine("IB.Do called");
    }
}

class Program
{
    static void Main()
    {
        Dual dual = new Dual();

        IA a = dual;
        IB b = dual;

        a.Do();
        b.Do();
    }
}