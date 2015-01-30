using System;

class Schedule
{
    static void Main()
    {
        int stHour = int.Parse(Console.ReadLine());
        int stMinute = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();
        int endHour = int.Parse(Console.ReadLine());
        int endMinute = int.Parse(Console.ReadLine());

        int outputHour = stHour + endHour;
        int outputMinute = stMinute + endMinute;

        if(outputMinute >= 60)
        {
            outputMinute -= 60;
            outputHour++;
        }

        int partOfDay = outputHour;

        do
        {
            if (partOfDay % 12 == 0)
            {
                switch (timeOfDay)
                {
                    case "AM": timeOfDay = "PM"; break;
                    case "PM": timeOfDay = "AM"; break;
                }
            }
            partOfDay--;
        } while (partOfDay >= 12);

        while(outputHour > 12)
        {
            outputHour -= 12;
        }

        Console.WriteLine(outputHour.ToString().PadLeft(2, '0') + ':' + outputMinute.ToString().PadLeft(2, '0') + ':' + timeOfDay);
    }
}