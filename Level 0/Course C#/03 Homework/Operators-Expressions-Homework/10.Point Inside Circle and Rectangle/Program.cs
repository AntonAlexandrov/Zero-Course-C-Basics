using System;

class PointInside
{
    static void Main()
    {
        double pointX, pointY;

        pointX = double.Parse(Console.ReadLine());
        pointY = double.Parse(Console.ReadLine());

        double cX = 1, cY = 1, cR = 1.5;
        double top=1, left=-1, width=6, height=2;

        bool insideCircle = false, outsideRectangle = true;

        if(Math.Sqrt(Math.Pow(Math.Abs(pointX - cX), 2.0) + Math.Pow(Math.Abs(pointY - cY), 2.0)) <= cR)
        {
            insideCircle = true;
        }
        if(pointX >= left && pointX <= (left + width) && pointY <= top && pointY >= (top - height))
        {
            outsideRectangle = false;
        }

        if(insideCircle && outsideRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}