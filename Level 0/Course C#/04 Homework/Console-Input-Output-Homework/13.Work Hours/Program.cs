using System;

class WorkHours
{
    static void Main()
    {
        //hours to finish project
        //how many days she has (only 90%)
        //1 day has 12 hours
        //average productivity

        int h = int.Parse(Console.ReadLine()); //hours to finish
        int d = int.Parse(Console.ReadLine()); //days available
        int p = int.Parse(Console.ReadLine()); //productivity in percent

        double totalHours = d * 0.9 * 12 * p / 100;

        if (h <= (int)totalHours)
        {
            Console.WriteLine("Yes");
            Console.WriteLine((int)totalHours - h);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine((int)totalHours - h);
        }
    }
}