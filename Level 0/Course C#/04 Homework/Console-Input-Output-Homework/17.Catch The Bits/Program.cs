using System;

class CatchBits
{
    static void Main()
    {
        /*WORKS SOMETIMES :D*/
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int bitIndex = 1;
        int currentNumberIndex = 0;

        int outputNumber = 0;
        int bitsInNumber = 0;

        while(currentNumberIndex < n)
        {
                int bit = (numbers[currentNumberIndex] >> (7 - bitIndex)) & 1;
                outputNumber = (outputNumber << 1) | bit;
                bitsInNumber++;
                if (bitsInNumber == 8)
                {
                    Console.WriteLine(outputNumber);
                    outputNumber = 0;
                    bitsInNumber = 0;
                }
                bitIndex += step;
                if(bitIndex >= 8)
                {
                    bitIndex -= 8;
                    currentNumberIndex++;
                }               
         
        }
        if(bitsInNumber > 0)
        {
            outputNumber = outputNumber << (8 - bitsInNumber);
            Console.WriteLine(outputNumber);
        }
    }
}