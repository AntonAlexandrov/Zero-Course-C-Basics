using System;

class Triangle
{
    static void Main()
    {
        //input the coordinates
        double aX = double.Parse(Console.ReadLine());
        double aY = double.Parse(Console.ReadLine());

        double bX = double.Parse(Console.ReadLine());
        double bY = double.Parse(Console.ReadLine());

        double cX = double.Parse(Console.ReadLine());
        double cY = double.Parse(Console.ReadLine());

        //calculate the sides
        double a = Math.Sqrt(Math.Pow(bX - cX, 2) + Math.Pow(bY - cY, 2));
        double b = Math.Sqrt(Math.Pow(cX - aX, 2) + Math.Pow(cY - aY, 2));
        double c = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2));
        
        if(a + b > c && b + c > a && c + a > b)
        {
            Console.WriteLine("Yes");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", c);
        }
    }

}