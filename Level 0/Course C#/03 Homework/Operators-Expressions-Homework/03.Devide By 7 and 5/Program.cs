using System;

class DevideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Devidable by 5 and 7?");

        if(number % 7 == 0 && number % 5 == 0)
        {
            Console.WriteLine("true");
        }
        else 
        {
            Console.WriteLine("false");
        }
    }
}