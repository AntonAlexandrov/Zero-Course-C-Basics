using System;

class BitAtPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        bool bitIs1;

        if(((n >> p) & 1) == 1)
        {
            bitIs1 = true;
        }
        else
        {
            bitIs1 = false;
        }

        Console.WriteLine(bitIs1);
    }
}