using System;
using System.Collections.Generic;

class Primes
{
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primeNums = new List<int>();


        for (int i = startNum; i <= endNum; i++)
        {
            int num = i;

            bool isPrime = true;

            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    isPrime = false;
                }
            }
            if(isPrime)
            {
                primeNums.Add(num);
            }
        }

        return primeNums;
    }

    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        List<int> primes = FindPrimesInRange(start, end);

        for(int i = 0; i < primes.Count; i++)
        {
            Console.Write("{0} ", primes[i]);
        }
    }
}