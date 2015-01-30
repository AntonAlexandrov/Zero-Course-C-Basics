using System;

class Extract3rdBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        n = n >> 3;
        n = n & 1;

        Console.WriteLine(n);
    }
}