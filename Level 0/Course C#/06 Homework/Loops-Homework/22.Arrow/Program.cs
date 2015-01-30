using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('.', (n - 1) / 2) + new string('#', n) + new string('.', (n - 1) / 2));

        for(int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string('.', (n - 1) / 2) + '#' + new string('.', n - 2)
                + '#' + new string('.', (n - 1) / 2));
        }

        Console.WriteLine(new string('#', (n + 1) / 2) + new string('.', n - 2) + new string('#', (n + 1) / 2));

        for(int i = 0; i < n-1; i++)
        {
            for(int j = 0; j < n*2 - 1; j++)
            {
                if (j == 1 + i || j == n * 2 - 1 - 2 - i)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}