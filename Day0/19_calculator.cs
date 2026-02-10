using System;

class Calc
{
    float n1, n2;
    string op;

    static void Calculator()
    {
        Calc n = new Calc();

        float num1 = n.n1 = float.Parse(Console.ReadLine());
        string sign = n.op = Console.ReadLine();
        float num2 = n.n2 = float.Parse(Console.ReadLine());

        float res = 0;

        switch(sign)
        {
            case "+":
                res = num1 + num2;
                Console.Write(res);
                break;

            case "-":
                res = num1 - num2;
                Console.Write(res);
                break;
            
            case "/":
                res = num1 / num2;
                Console.Write(res.ToString("F2"));
                break;

            case "*":
                res = num1 * num2;
                Console.Write(res);
                break;
        }
    }

    static void Main()
    {
        Calculator();
    }
}