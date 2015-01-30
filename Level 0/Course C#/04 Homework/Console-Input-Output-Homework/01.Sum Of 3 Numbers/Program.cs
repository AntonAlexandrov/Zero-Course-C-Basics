using System;

class SumOf3Numbers
{
    static void Main()
    {
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}