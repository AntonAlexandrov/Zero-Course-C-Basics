using System;

class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter: {0:F2}", 2 * Math.PI * r);
        Console.WriteLine("Perimeter: {0:F2}", Math.Pow(r,2) * Math.PI);
    }
}