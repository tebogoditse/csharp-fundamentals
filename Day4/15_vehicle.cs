using System;

public class Vehicle 
{ 
    public virtual string Describe()
    {
        string sentence = "I am a Vihicle";
        return sentence;
    }
} 

public class Car : Vehicle 
{ 
    public override string Describe()
    {
        string sentence = "Car: I am a car";
        return sentence;
    } 
} 

public class Truck : Vehicle 
{
    public override string Describe()
    {
        string sentence = "Truck: I am a truck";
        return sentence;
    } 
}

class Program
{
    static void Main()
    {
        Vehicle vehicle = null;

        string input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            if (input == "car")
            {
                vehicle = new Car();
            }
            else if (input == "truck")
            {
                vehicle = new Truck();
            }
            else
            {
                Console.WriteLine("Invalid input!!! Try Again.");
                continue;
            }
            Console.WriteLine(vehicle.Describe());
        }
    }
}