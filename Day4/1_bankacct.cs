using System;
using System.Globalization;

public class BankAccount 
{ 
    private decimal balance; 
    
    public BankAccount(decimal initial)
    {
        balance = initial;
    }

    public decimal GetBalance()
    {
        return balance;
    } 
}

class Program
{
    static void Main()
    {
        decimal value = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        BankAccount balance = new BankAccount(value);

        Console.Write("Balance: " + balance.GetBalance().ToString("F2", CultureInfo.InvariantCulture));
    }
}