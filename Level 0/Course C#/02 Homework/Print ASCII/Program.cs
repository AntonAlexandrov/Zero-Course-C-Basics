using System;

class PrintASCII
{
    static void Main()
    {
        char symbol;
        for(int i = 0; i < 256; i++)
        {
            symbol = (char)i;
            Console.WriteLine(symbol);
        }
    }
}