using System;

class ExchangeVariables
{
    static void Main()
    {
        int a = 5, b = 10;
        int c;

        Console.WriteLine("a = {0}, b = {1}", a, b);

        c = a;
        a = b;
        b = c;

        Console.WriteLine("New a = {0}, b = {1}", a, b);
    }
}
