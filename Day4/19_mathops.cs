using System;
using System.Globalization;

public class MathOps 
{ 
    public int Add(int a,int b)
    {
        return a + b;
    }
    
    public double Add(double a,double b)
    {
        return a + b;
    } 
}

class Program
{
    static void Main()
    {
        string input;
        while ((input = Console.ReadLine()) != null && input != "")
        {
            string[] inputs = input.Split(' ');

            if (inputs.Length != 3)
            {
                Console.WriteLine("Invalid Input!!! Try Again");
                continue;
            }

            string type = inputs[0];
            if (type == "int")
            {
                MathOps intType = new MathOps();
                Console.WriteLine(intType.Add(int.Parse(inputs[1]), int.Parse(inputs[2])));
            }
            else if (type == "double")
            {
                MathOps doubleType = new MathOps();
                double result = doubleType.Add(double.Parse(inputs[1], CultureInfo.InvariantCulture), double.Parse(inputs[2], CultureInfo.InvariantCulture));
                Console.WriteLine(result.ToString("", CultureInfo.InvariantCulture));
            }
        }       
    }
}