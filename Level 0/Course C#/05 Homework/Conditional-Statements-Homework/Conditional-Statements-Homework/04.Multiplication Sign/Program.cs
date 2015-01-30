using System;

class Sign
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        //if one is negative
        if(a > 0 && b > 0 && c < 0)
        {
            Console.WriteLine('-');
        }
        else if(a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine('-');
        }
        else if(a < 0 && b > 0 && c > 0)
        {
            Console.WriteLine('-');
        }
        //if two are negative
        else if (a > 0 && b < 0 && c < 0)
        {
            Console.WriteLine('+');
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine('+');
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine('+');
        }
        //if three are negative
        else if (a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine('-');
        }
        //if all are positive
        else if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine('+');
        }
        //if 0 is involved
        else
        {
            Console.WriteLine('0');
        }
    }
}