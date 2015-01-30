using System;
using System.Numerics;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger nFact = n;
        BigInteger kFact = k;
        BigInteger diffFact = n - k;

        for(int i = n - 1; i > 0; i--)
        {
            if(i < k)
            {
                kFact *= i;
            }
            if(i < n - k)
            {
                diffFact *= i;
            }
            nFact *= i;
        }
        BigInteger result = nFact / (kFact * diffFact);

        Console.WriteLine(result);
    }
}