using System;

class OddOrEven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Odd?");
        if(number % 2 != 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}