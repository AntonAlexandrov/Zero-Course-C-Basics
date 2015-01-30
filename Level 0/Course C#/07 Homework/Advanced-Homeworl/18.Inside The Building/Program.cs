using System;

class InsideBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        //if they are inside the lower rectangle 3 * h ,h
        bool point1Inside1 = x1 >= 0 && x1 <= 3 * h && y1 >= 0 && y1 <= h;
        bool point2Inside1 = x2 >= 0 && x2 <= 3 * h && y2 >= 0 && y2 <= h;
        bool point3Inside1 = x3 >= 0 && x3 <= 3 * h && y3 >= 0 && y3 <= h;
        bool point4Inside1 = x4 >= 0 && x4 <= 3 * h && y4 >= 0 && y4 <= h;
        bool point5Inside1 = x5 >= 0 && x5 <= 3 * h && y5 >= 0 && y5 <= h;

        //if they are inside the upper rectangle h , 3 * h
        bool point1Inside2 = x1 >= h && x1 <= 2 * h && y1 >= h && y1 <= 4 * h;
        bool point2Inside2 = x2 >= h && x2 <= 2 * h && y2 >= h && y2 <= 4 * h;
        bool point3Inside2 = x3 >= h && x3 <= 2 * h && y3 >= h && y3 <= 4 * h;
        bool point4Inside2 = x4 >= h && x4 <= 2 * h && y4 >= h && y4 <= 4 * h;
        bool point5Inside2 = x5 >= h && x5 <= 2 * h && y5 >= h && y5 <= 4 * h;

        if( point1Inside1 || point1Inside2 )
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }

        if (point2Inside1 || point2Inside2)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }

        if (point3Inside1 || point3Inside2)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }

        if (point4Inside1 || point4Inside2)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }

        if (point5Inside1 || point5Inside2)
        {
            Console.WriteLine("inside");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}