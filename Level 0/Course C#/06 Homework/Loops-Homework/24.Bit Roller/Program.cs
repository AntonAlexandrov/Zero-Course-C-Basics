using System;

class Roller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //number to roll
        int f = int.Parse(Console.ReadLine()); //position
        int r = int.Parse(Console.ReadLine()); //number of rolls

        int changingBit = 0;
        int firstBit;

        for(int i = 0; i < r; i++)
        {
            if(f != 0)
            {
                firstBit = n & 1;
            }
            else
            {
                firstBit = (n << 1) & 1;
            }
            
            for(int j = 0; j < 19 - 1; j++)
            {
                if(j == f - 1 && f != 18)
                {
                    changingBit = (n >> (j + 2)) & 1;
                }
                else if(j == f - 1 && f == 18)
                {
                    changingBit = firstBit;
                }
                else if(j == f)
                {
                    changingBit = n >> (j) & 1;
                }
                else
                {
                    changingBit = (n >> (j + 1)) & 1;
                }
                
                if( changingBit == 0)
                {
                    n &= ~(1 << j);
                }
                else
                {
                    n |= 1 << j;
                }
            }
            if(firstBit == 0 && f != 18)
            {
                n &= ~(1 << 18);
            }
            else if( firstBit == 1 && f != 18)
            {
                n |= 1 << 18;
            }
        }

        Console.WriteLine(n);
    }
}