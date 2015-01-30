using System;

class ExtractBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        n = n >> p;
        n = n & 1;

        Console.WriteLine(n);
    }
}