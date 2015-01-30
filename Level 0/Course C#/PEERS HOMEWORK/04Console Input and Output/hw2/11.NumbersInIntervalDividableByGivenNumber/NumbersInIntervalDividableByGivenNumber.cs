using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        uint start = uint.Parse(Console.ReadLine());
        uint end = uint.Parse(Console.ReadLine());
        uint p = 0;
        for (uint i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("p={0}", p);
    }
}