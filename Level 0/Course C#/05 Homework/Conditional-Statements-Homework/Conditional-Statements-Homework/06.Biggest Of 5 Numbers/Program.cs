using System;

class BiggestNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine(a);
        }
        if (b > a && b > c && b > d && b > e)
        {
            Console.WriteLine(b);
        }
        if (c > b && c > a && c > d && c > e)
        {
            Console.WriteLine(c);
        }
        if (d > b && d > c && d > a && d > e)
        {
            Console.WriteLine(d);
        }
        if (e > b && e > c && e > a && e > d)
        {
            Console.WriteLine(e);
        }
    }
}