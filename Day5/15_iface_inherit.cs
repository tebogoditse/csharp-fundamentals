using System;

public interface IAnimal 
{ 
    void Speak(); 
} 

public interface IMammal : IAnimal
{ 
    void Nurse(); 
} 

public class Dog : IMammal 
{ 
    public void Speak()
    {
        Console.WriteLine("Woof");
    }
    
    public void Nurse()
    {
        Console.WriteLine("Nursing");
    } 
}

class Program
{
    static void Main()
    {
        IMammal mammal = new Dog();

        mammal.Speak();
        mammal.Nurse();
    }
}