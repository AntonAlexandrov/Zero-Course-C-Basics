using System;
class MagicDates
{
    static string DateToString(int day, int month, int year, bool dash)
    {
        string dateStr = string.Empty;
        if (!dash)
        {
            string yearStr = Convert.ToString(year);
            string monthStr = Convert.ToString(month);
            if (monthStr.Length == 1)
            {
                monthStr = '0' + monthStr;
            }
            string dayStr = Convert.ToString(day);
            if (dayStr.Length == 1)
            {
                dayStr = '0' + dayStr;
            }
            dateStr = dayStr + monthStr + yearStr;
        }
        else
        {
            string yearStr = Convert.ToString(year);
            string monthStr = Convert.ToString(month);
            if (monthStr.Length == 1)
            {
                monthStr = '0' + monthStr;
            }
            string dayStr = Convert.ToString(day);
            if (dayStr.Length == 1)
            {
                dayStr = '0' + dayStr;
            }
            dateStr = dayStr + '-' + monthStr + '-' + yearStr;
        }

        return dateStr;
    }
    static int DateWeight(int day, int month, int year)
    {
        string dateStr = DateToString(day, month, year, false);

        //Console.Write(dateStr);

        int weight = 0;
        for (int i = 0; i < dateStr.Length; i++)
        {
            for (int j = 0; j < dateStr.Length; j++)
            {
                if(i != j)
                {
                    weight += (int)Char.GetNumericValue(dateStr[i]) * (int)Char.GetNumericValue(dateStr[j]);
                }
            }
        }
        //Console.WriteLine(" ---> {0}", weight);
        return weight / 2;
    }
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicWeight = int.Parse(Console.ReadLine());

        int datesCount = 0;
        
        for(int year = startYear; year <= endYear; year++)
        {
            for(int month = 1; month <= 12; month++)
            {
                for(int day = 1; day <= 31; day++)
                {
                    if (DateWeight(day, month, year) == magicWeight)
                    {
                        Console.WriteLine(DateToString(day, month, year, true));
                        datesCount++;
                    }

                    if (year % 4 != 0 && day == 28 && month == 2)
                    {
                        break;
                    }
                    else if (year % 4 == 0 && day == 29 && month == 2)
                    {
                        break;
                    }

                    if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        if(day == 30)
                        {
                            break;
                        }
                    }
                }
            }
        }

        if (datesCount == 0)
        {
            Console.WriteLine("No");
        }
    }
}