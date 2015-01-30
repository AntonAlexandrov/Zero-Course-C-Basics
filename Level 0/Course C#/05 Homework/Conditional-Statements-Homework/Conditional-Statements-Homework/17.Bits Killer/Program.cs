using System;
using System.Collections.Generic;

class Killer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for(int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        List<int> outputNums = new List<int>();
        int noCopyBit = 6;
        int noCopyNumber = 0;
        int currentNumber = 0;
        int currentNumberBits = 0;

        for(int numIndex = 0; numIndex < n; numIndex++)
        {
            for(int bitIndex = 7; bitIndex >= 0; bitIndex--)
            {
                if(bitIndex != noCopyBit || numIndex != noCopyNumber)
                {                    
                    currentNumber = currentNumber << 1;
                    currentNumber = currentNumber | ((numbers[numIndex] >> bitIndex) & 1);

                    currentNumberBits++;
                    if (currentNumberBits == 8)
                    {
                        currentNumberBits = 0;
                        outputNums.Add(currentNumber);
                        currentNumber = 0;
                    }
                }
                if(bitIndex == noCopyBit && numIndex == noCopyNumber)
                {
                    noCopyBit -= step;
                    if(noCopyBit < 0)
                    {
                        noCopyBit += 8;
                        noCopyNumber++;
                    }
                }                
            }
        }

        if(currentNumberBits < 8 && currentNumberBits != 0)
        {
            currentNumber = currentNumber << (8 - currentNumberBits);
            outputNums.Add(currentNumber);
        }

        for(int i = 0; i < outputNums.Count; i++)
        {
            Console.WriteLine(outputNums[i]);
        }

    }
}