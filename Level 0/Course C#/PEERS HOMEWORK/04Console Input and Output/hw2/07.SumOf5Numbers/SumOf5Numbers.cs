using System;
using System.Linq;

class SumOf5Numbers
{
    static void Main()
    {
        string full = Console.ReadLine();
        double[] numbers = Array.ConvertAll(full.Split(' '), Double.Parse);
        double sum = numbers.Sum();
        Console.WriteLine(sum);
    }
}