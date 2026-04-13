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
        Console.WriteLine("(IA)dual -> IA.Do() output");
    }

    void IB.Do()
    {
        Console.WriteLine("(IB)dual -> IB.Do() output");
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