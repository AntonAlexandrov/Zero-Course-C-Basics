using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //roof
        for (int i = 0; i < (n+1) / 2 - 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == (n - 1) / 2 - i || j == (n - 1) / 2 + i)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
        //1 line ceiling
        Console.WriteLine(new string('*', n));
        //1st floor
        for (int i = 0; i < n - (n+1) / 2 - 1; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(j == n / 4 || j == n - 1 - n/4)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
        //1 line ground
        Console.Write(new string('.', n/4));
        Console.Write(new string('*', n - 2* (n / 4)));
        Console.WriteLine(new string('.', n / 4));
    }
}