using System;
using System.Globalization;

public interface IPayment 
{ 
    void Pay(decimal amount); 
} 

public class CreditCard : IPayment 
{ 
    public void Pay(decimal amount)
    {
        Console.WriteLine("CreditCard paid " + amount.ToString("F2", CultureInfo.InvariantCulture));
    }
} 

public class Paypal : IPayment 
{ 
    public void Pay(decimal amount)
    {
        Console.WriteLine("Paypal paid " + amount.ToString("F2", CultureInfo.InvariantCulture));
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

            if (inputs.Length != 2)
            {
                Console.WriteLine("Invalid Input!!! Try Again");
                continue;
            }

            string method = inputs[0];
            decimal amount = decimal.Parse(inputs[1], CultureInfo.InvariantCulture);

            IPayment payment = null;

            if (method == "credit")
            {
                payment = new CreditCard();
            }
            else if (method == "paypal")
            {
                payment = new Paypal();
            }
            payment.Pay(amount);
        }
    }
}