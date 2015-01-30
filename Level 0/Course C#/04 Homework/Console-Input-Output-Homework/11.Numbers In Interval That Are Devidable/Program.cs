using System;

class DevidableNumbers
{
    static void Main()
    {
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        int pNumbers = 0;

        for (int i = min; i <= max; i++)
        {
            if(i % 5 == 0)
            {
                pNumbers++;
            }
        }
        Console.WriteLine(pNumbers);
    }
}