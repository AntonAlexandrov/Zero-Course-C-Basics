using System;

class FormatNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write('|');
        Console.Write("{0,-10:X}", a);
        Console.Write('|');
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write('|');
        Console.Write("{0,10:F2}", b);
        Console.Write('|');
        Console.Write("{0,-10:F3}", c);
        Console.WriteLine('|');
    }
}