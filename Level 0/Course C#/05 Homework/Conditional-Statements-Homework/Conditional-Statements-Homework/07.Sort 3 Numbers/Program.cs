using System;

class SortNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b) // _a,b_
        {
            if (a > c) //a,b/c
            {
                if (b > c) //a, b, c
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else // a, c, b
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else //c, a, b
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (b > c) //b,a/c
            {
                if (a > c) //b, a, c
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else // b, c, a
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else //c, b, a
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}