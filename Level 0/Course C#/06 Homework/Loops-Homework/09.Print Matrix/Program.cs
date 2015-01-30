using System;

class Matrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int add = 0;

        for(int i = 1; i <= n; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                Console.Write("{0} ", j + add);
            }
            add++;
            Console.WriteLine();
        }
    }
}