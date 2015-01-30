using System;

class FourDigitNumber
{
    static void Main()
    {
        string number = Console.ReadLine();
        char a = number[0], b = number[1], c = number[2], d = number[3];

        Console.WriteLine("Reversed: {3}{2}{1}{0}", a, b, c, d);
        Console.WriteLine("Last digit in first position: {3}{0}{1}{2}", a, b, c, d);
        Console.WriteLine("Exchange second and third digit: {0}{2}{1}{3}", a, b, c, d);
    }
}