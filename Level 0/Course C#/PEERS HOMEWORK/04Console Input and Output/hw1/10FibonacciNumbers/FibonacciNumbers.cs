using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int fibonacci = a;
            a = b;
            b = fibonacci + b;
        }
    }
}
    
