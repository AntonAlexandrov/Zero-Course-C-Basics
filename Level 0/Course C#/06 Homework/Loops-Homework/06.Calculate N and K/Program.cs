using System;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int nFact = n;
        int kFact = k;

        for(int i = n - 1; i > 0; i--)
        {
            if(i < k)
            {
                kFact *= i;
            }
            nFact *= i;
        }
        double result = nFact / kFact;
        Console.WriteLine(result);
    }
}