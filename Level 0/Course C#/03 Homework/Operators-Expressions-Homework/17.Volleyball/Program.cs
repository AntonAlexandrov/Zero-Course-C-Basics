using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine()); //number of holidays
        int h = int.Parse(Console.ReadLine()); //number of days in his hometown
        /*48 weekends in a year*/

        double totalPlays = p * 2 / 3.0 + (48 - h) * 3 / 4.0 + h;
        if(year == "leap")
        {
            totalPlays *= 115;
            totalPlays /= 100;
        }

        Console.WriteLine((int)totalPlays);
    }
}