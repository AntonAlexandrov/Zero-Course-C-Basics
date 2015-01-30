using System;

class AgeAfterYears
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.Write("Input your Birthday in the format year/month/day: ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        if ((currentDate.Day * 0.00274) + (currentDate.Month * 0.083) >= (birthDate.Day * 0.00274) + (birthDate.Month * 0.083))
        {
            Console.WriteLine("You are " + (currentDate.Year - birthDate.Year) + " years old");
            Console.WriteLine("In 10 years you will be " + (currentDate.Year - birthDate.Year + 10) + " years old");
        }
        else
        {
            Console.WriteLine("You are " + (currentDate.Year - birthDate.Year - 1) + " years old");
            Console.WriteLine("In 10 years you will be " + (currentDate.Year - birthDate.Year + 10 - 1) + " years old");
        }
    }
}
