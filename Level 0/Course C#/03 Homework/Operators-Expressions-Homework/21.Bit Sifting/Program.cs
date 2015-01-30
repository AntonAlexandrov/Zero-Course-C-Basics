using System;

class BitSifting
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long[] arrayOfSieves = new long[int.Parse(Console.ReadLine())];
        for(int i = 0; i < arrayOfSieves.Length; i++)
        {
            arrayOfSieves[i] = long.Parse(Console.ReadLine());
        }
        bool bitPassed = true;
        int nBitsPassed = 0;
        long numberBit;
        long sieveBit;
        int sieveIndex = 0;

        for(int j = 0; j < 64; j++)//loop through the bits of the number we have to sift
        {
            numberBit = (number >> j) & 1;
            if(numberBit == 1)
            {
                while(sieveIndex < arrayOfSieves.Length)//loop through the values of the bits at position j to see if the bit passes
                {
                    sieveBit = (arrayOfSieves[sieveIndex] >> j) & 1;
                    if(sieveBit == 1)
                    {
                        bitPassed = false;
                        sieveIndex++;
                    }
                    else
                    {
                        sieveIndex++;
                    }
                }
                if(bitPassed)
                {
                    nBitsPassed++;
                }
                bitPassed = true;
                sieveIndex = 0;
            }
        }

        Console.WriteLine(nBitsPassed);
    }
}