using System;

class SolveEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = Math.Pow(b, 2) - 4 * a * c;
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if ( d == 0)
        {
            Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
        }
        else
        {
            Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(d)) / (2 * a));
        }

    }
}