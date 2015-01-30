using System;


class PointInCircle
{
    static void Main()
    {
        double pointX, pointY;
        int r = 2;

        pointX = double.Parse(Console.ReadLine());
        pointY = double.Parse(Console.ReadLine());

        if (Math.Sqrt(Math.Pow(pointX, 2.0) + Math.Pow(pointY, 2.0)) <= r)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
