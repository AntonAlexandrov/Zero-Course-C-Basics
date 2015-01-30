using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;

        if (start > end)
        {
            start = start + end;
            end = start - end;
            start = start - end;
        }
        bool isNone = false;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i);
                p++;
                isNone = true;
                if (i < end - 2)
                {
                    Console.Write(",");
                }
            }
        }
        if (!isNone)
        {
            Console.WriteLine("-");
        }
        Console.WriteLine("\n" + p);
    }
}

