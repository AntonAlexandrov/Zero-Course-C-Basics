using System;

class RandomizedNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        int printed = 0;

        for(int i = 0; i < n; i++)
        {
            numbers[i] = i+1;
        }

        Random random = new Random();

        while(printed < n)
        {
            int rndIndex = random.Next(0, n);
            if(numbers[rndIndex] != 0)
            {
                Console.Write("{0} ", numbers[rndIndex]);
                numbers[rndIndex] = 0;
                printed++;
            }
        }
    }
}