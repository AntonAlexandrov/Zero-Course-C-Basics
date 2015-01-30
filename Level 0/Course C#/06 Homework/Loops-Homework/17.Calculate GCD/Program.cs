using System;

class GCD
{
    static void Main()
    {
        //works only with positive integers
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int smaller = Math.Min(a, b);
        int bigger = Math.Max(a, b);

        int num1 = bigger, num2 = smaller;

        while(num1 != num2)
        {
            num1 = Math.Abs(num1 - num2);
            num2 = Math.Min(num1, num2);
        }
        Console.WriteLine(num1);
    }
}