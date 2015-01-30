using System;
class DataCheck
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter two dates");
        Console.Write("Enter first date: ");
        string time = Console.ReadLine();
        DateTime firstDate = DateTime.Parse(time);
        firstDate.ToString("dd.MM.yyyy");

        Console.Write("Enter second date: ");
        string secondTime = Console.ReadLine();
        DateTime secondDate = DateTime.Parse(secondTime);
        secondDate.ToString("dd.MM.yyyy");
        TimeSpan diff = secondDate - firstDate;
        double days = diff.TotalDays;
        Console.WriteLine(days);
    }
}
