using System;

class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        ulong bit1, bit2, bit3;

        for (int i = 63; i >= 2; i--)
        {
            bit1 = (ulong)(1 & number >> i);
            bit2 = (ulong)(1 & number >> (i - 1));
            bit3 = (ulong)(1 & number >> (i - 2));
            if(bit1 == bit2 && bit2 == bit3)
            {
                if(bit1 == 0)
                {
                    number |= (ulong)1 << i;
                    number |= (ulong)1 << (i - 1);
                    number |= (ulong)1 << (i - 2);
                }
                else
                {
                    number &= ~((ulong)1 << i);
                    number &= ~((ulong)1 << (i - 1));
                    number &= ~((ulong)1 << (i - 2));
                }
                i -= 2;
            }
        }

        Console.WriteLine(number);
    }
}