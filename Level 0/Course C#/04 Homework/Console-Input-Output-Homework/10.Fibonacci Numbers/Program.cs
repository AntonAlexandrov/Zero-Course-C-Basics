using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] fibonacci = new int[n];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for(int i = 0; i < n; i++)
        {
            if(i < 2)
            {
                Console.Write(fibonacci[i]);
                Console.Write(' ');
            }
            else
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                Console.Write(fibonacci[i]);
                Console.Write(' ');
            }
        }
        Console.WriteLine();
    }
}