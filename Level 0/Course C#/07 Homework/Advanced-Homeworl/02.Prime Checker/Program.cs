using System;

class PrimeCheker
{
    static bool IsPrime(long n)
    {
        bool isPrime = true;
        long root = (long)Math.Sqrt(n);

        for(int i = 2; i < root; i++)//if 'root(n)' is not devidable by any other number then 'n' is prime
        {
            if(n % i == 0)
            {
                isPrime = false;
            }
        }

        return isPrime;
    }
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
    }
}