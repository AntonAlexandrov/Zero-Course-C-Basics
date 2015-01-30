using System;

class JoroPlaysFootball
{
    static void Main()
    {
        int nPlays;
        double normalWeekends;
        double halfHolidays;
        byte yearWeekends = 52;

        char year; //for leap year
        byte p; //for holidays
        byte h; //number of weekends in his hometown

        year = char.Parse(Console.ReadLine());
        p = byte.Parse(Console.ReadLine());
        h = byte.Parse(Console.ReadLine());

        normalWeekends = (yearWeekends - h) * 2 / 3; //calculate how many weekends Joro plays
        halfHolidays = p / 2;

        nPlays = (int)(halfHolidays + normalWeekends + h); //should be normalWeekends * 2 because he play Saturday AND Sunday
        if(year == 't')
        {
            nPlays += 3;
        }

        Console.WriteLine(nPlays);
    }
}