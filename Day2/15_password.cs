using System;

class PasswdChecker
{
    public string passwd;

    static void ValidatePassword()
    {
        PasswdChecker check = new PasswdChecker();
        check.passwd = Console.ReadLine();

        if (check.passwd.Length >= 8)
        {
            Console.Write("Valid");
        }
        else
        {
            Console.Write("Invalid");
        }
        
    }

    static void Main()
    {
        ValidatePassword();
    }
    
}