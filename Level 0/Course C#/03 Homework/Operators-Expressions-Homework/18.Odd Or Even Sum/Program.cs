using System;

class OddOrEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0; int evenSum = 0;

        for(int i = 0; i < n*2; i++)
        {
            if(i % 2 == 0)
            {
                oddSum += int.Parse(Console.ReadLine());
            }
            else
            {
                evenSum += int.Parse(Console.ReadLine());
            }
        }
        if(oddSum - evenSum != 0)
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
        else
        {
            Console.WriteLine("Yes, sum={0}", oddSum);
        }
    }
}