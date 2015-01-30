using System;

class ExchangeBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        uint[] firstSequence = new uint[3];
        uint[] secondSequence = new uint[3];

        for (int i = 0; i < 3; i++)
        {
            firstSequence[i] = (number >> 3 + i) & 1;
        }
        for (int i = 0; i < 3; i++)
        {
            secondSequence[i] = (number >> 24 + i) & 1;
        }

        for(int i = 0; i < 3; i++)
        {
            if(firstSequence[i] == 0)
            {
                number &= (uint)~( 1 << 24 + i);
            }
            else
            {
                number |= (uint)1 << 24 + i;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (secondSequence[i] == 0)
            {
                number &= (uint)~(1 << 3 + i);
            }
            else
            {
                number |= (uint)1 << 3 + i;
            }
        }

        Console.WriteLine(number);
    }
}