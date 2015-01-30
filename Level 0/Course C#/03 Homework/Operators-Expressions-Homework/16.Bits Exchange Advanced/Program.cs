using System;

class ExchangeBits
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine()); //number to be reworked
        int p = int.Parse(Console.ReadLine()); //start of first sequence
        int q = int.Parse(Console.ReadLine()); //start of second sequence
        int k = int.Parse(Console.ReadLine()); //interval of both seqences

        if (Math.Max(p, q) + k > 32 || p > 32 || p < 0 || q > 32 || q < 0)
        {
            Console.WriteLine("out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q)) //check if overlapping
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            uint[] firstSequence = new uint[k];
            uint[] secondSequence = new uint[k];

            for (int i = 0; i < k; i++)
            {
                firstSequence[i] = (n >> p + i) & 1;
            }
            for (int i = 0; i < 3; i++)
            {
                secondSequence[i] = (n >> q + i) & 1;
            }

            for (int i = 0; i < k; i++)
            {
                if (firstSequence[i] == 0)
                {
                    n &= (uint)~(1 << q + i);
                }
                else
                {
                    n |= (uint)1 << q + i;
                }
            }
            for (int i = 0; i < k; i++)
            {
                if (secondSequence[i] == 0)
                {
                    n &= (uint)~(1 << p + i);
                }
                else
                {
                    n |= (uint)1 << p + i;
                }
            }

            Console.WriteLine(n);
        }
    }
}