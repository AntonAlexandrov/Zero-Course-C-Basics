﻿using System;

class BigNumberSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            Console.WriteLine(Math.Pow(-1, i) * i);
        }
    }
}
