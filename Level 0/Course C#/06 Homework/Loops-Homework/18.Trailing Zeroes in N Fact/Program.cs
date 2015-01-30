using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());

        int fiveCount = 0;

        int reminder; int closestPowerFive = 0;
        int num = inputNum;

        do
        {
            reminder = num % 5;
            num = num / 5 + reminder;
            closestPowerFive++;

        } while (num >= 5);

        for(int i = 1; i <= inputNum; i++)
        {
            for(int j = 1; j <= closestPowerFive; j++)
            {
                if(i % Math.Pow(5, j) == 0)
                {
                    fiveCount++;
                }
            }
        }

        Console.WriteLine(fiveCount);
    }
}