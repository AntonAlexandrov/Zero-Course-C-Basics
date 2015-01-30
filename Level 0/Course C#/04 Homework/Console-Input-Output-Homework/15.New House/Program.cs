using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < (n + 1) / 2; i++)//draw the roof
        {
            for (int j = 0; j < n; j++)
            {
                if(j >= (n+1)/2 - 1 - i && j <= (n+1)/2 - 1 + i)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
        }
        for(int i = 0; i < n; i++)//draw the floors
        {
            for(int j = 0; j < n; j++)
            {
                if(j != 0 && j != n - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('|');
                }
            }
            Console.WriteLine();
        }

    }
}