using System;

class Exchange
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            int c = first;
            first = second;
            second = c;
            Console.WriteLine("Exchanged values: {0}, {1}", first, second);
        }
        else
        {
            Console.WriteLine("Not exchanged values: {0}, {1}", first, second);
        }
    }
}