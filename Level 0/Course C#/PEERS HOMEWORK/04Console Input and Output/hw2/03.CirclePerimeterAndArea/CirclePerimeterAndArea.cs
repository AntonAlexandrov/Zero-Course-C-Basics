using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r = Math.Round(double.Parse(Console.ReadLine()), 2);
        double numberPi = Math.Round(Math.PI, 7);
        double circlePerimeter = Math.Round((2 * numberPi * r), 2);
        double circleArea = Math.Round((numberPi * Math.Pow(r, 2)), 2);
        Console.WriteLine("Perimeter: {0}\nArea: {1}", circlePerimeter, circleArea);
    }
}