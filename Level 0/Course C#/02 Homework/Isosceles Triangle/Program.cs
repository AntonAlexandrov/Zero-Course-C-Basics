using System;

class PrintTriangle
{
    static void Main()
    {
        string triangle = "   \u00a9\n  \u00a9 \u00a9\n \u00a9   \u00a9\n\u00a9 \u00a9 \u00a9 \u00a9";

        Console.WriteLine(triangle);
        char copyRight = '\u00A9';
        Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", copyRight);
    }
}