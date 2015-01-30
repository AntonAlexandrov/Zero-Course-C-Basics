using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // (2n)! / ((1+n)! * n!)

        BigInteger twoNFact = 2 * n;
        BigInteger onePlusNFact = 1 + n;
        BigInteger nFact = n;

        for(int i = 2*n - 1; i > 0; i--)
        {
            if( i < 1+ n)
            {
                onePlusNFact *= i;
            }
            if( i < n)
            {
                nFact *= i;
            }
            twoNFact *= i;
        }
        BigInteger result = twoNFact / (onePlusNFact * nFact);
        Console.WriteLine(result);
    }
}