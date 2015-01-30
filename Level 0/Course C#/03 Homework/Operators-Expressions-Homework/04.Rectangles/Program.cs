using System;

class Rectangles
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());

        float perimeter = 2 * a + 2 * b;
        float area = a * b;

        Console.WriteLine("Perimeter = " + perimeter);
        Console.WriteLine("Area = " + area);
    }
}