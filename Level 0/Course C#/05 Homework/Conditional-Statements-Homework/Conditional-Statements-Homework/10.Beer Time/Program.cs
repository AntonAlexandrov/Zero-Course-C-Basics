using System;

class BeerTime
{
    static void Main()
    {
        DateTime time = DateTime.Parse(Console.ReadLine());
        if(time.Hour < 3 || time.Hour >= 13)
        {
            Console.WriteLine("beer time!");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
        //Console.WriteLine(time.TimeOfDay);
    }
}