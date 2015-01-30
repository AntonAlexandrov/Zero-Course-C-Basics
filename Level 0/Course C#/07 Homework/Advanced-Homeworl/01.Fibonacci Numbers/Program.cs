using System;

class Fibonacii
{
    static int Fib(int n)
    {
        int[] fibonacci = new int[n+1];
        fibonacci[0] = 1;
        fibonacci[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        return fibonacci[n];
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int outputN = Fib(n);
        Console.WriteLine(outputN);
    }
}