using System;

class CheckPrimeNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        for(int i = 2; i < n; i++)
        {
            if(n % i == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);
    }
}