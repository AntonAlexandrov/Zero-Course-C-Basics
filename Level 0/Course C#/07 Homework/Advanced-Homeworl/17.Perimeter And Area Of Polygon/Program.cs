using System;
using System.Collections.Generic;

class Polygon
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Point> points = new List<Point>();
        
        //fill list of points
        for(int i = 0; i < n; i++)
        {
            string inputStr = Console.ReadLine();
            string[] coords = inputStr.Split(' ');

            points.Add(new Point(double.Parse(coords[0]), double.Parse(coords[1])));
        }

        //calculate area
        double area = 0;
        for(int i = 0; i < points.Count; i++)
        {
            if(i < points.Count - 1)
            {
                area += points[i].x * points[i + 1].y - points[i].y * points[i + 1].x;
            }
            else
            {
                area += points[i].x * points[0].y - points[i].y * points[0].x;
            }            
        }
        area /= 2;

        //calculate perimeter
        double perimeter = 0;

        for(int i = 0; i < points.Count; i++)
        {
            if (i < points.Count - 1)
            {
                perimeter += Math.Sqrt(Math.Pow(points[i].x - points[i + 1].x, 2) +
                    Math.Pow(points[i].y - points[i + 1].y, 2));
            }
            else
            {
                perimeter += Math.Sqrt(Math.Pow(points[i].x - points[0].x, 2) +
                    Math.Pow(points[i].y - points[0].y, 2));
            }    
        }

        Console.WriteLine("{0:F2}", perimeter);
        Console.WriteLine("{0:F2}", Math.Abs(area));
    }
}