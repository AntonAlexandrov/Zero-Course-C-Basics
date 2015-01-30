using System;

class ModifyBit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        sbyte p = sbyte.Parse(Console.ReadLine());
        sbyte v = sbyte.Parse(Console.ReadLine());

        int mask;

        if(v == 1)
        {
            mask = 1 << p;
            n |= mask;
            Console.WriteLine(n);
        }
        else
        {
            mask = ~(1 << p);
            n &= mask;
            Console.WriteLine(n);
        }
    }
}