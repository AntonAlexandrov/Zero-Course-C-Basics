﻿using System;

class HalfSum
{
    static void Main()
    {
        int firstSum = 0;
        int secondSum = 0;
        int n;

        n = int.Parse(Console.ReadLine());

        for ( int i = 0; i < 2*n; i++)
        {
            if( i < n)
            {
                firstSum += int.Parse(Console.ReadLine());
            }
            else
            {
                secondSum += int.Parse(Console.ReadLine());
            }            
        }

        if(firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum={0}", firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
        }
    }
}