﻿using System;

class PrintNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.Write(i);
            Console.Write(' ');
        }
        Console.WriteLine();
    }
}