using System;

class FormattingNumbers
{
    static void Main()
    {
        int a;
        // 'a' must be int and need to be (0 ≤ a ≤ 500)
        while (!int.TryParse(Console.ReadLine(), out a) || a < 0 || a > 499) Console.WriteLine("'a' must be greater or equal to 0 and lower than or equal to 500");
        double b;
        while (!double.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Enter a number.");
        double c;
        while (!double.TryParse(Console.ReadLine(), out c)) Console.WriteLine("Enter a number.");

        Console.Write("|{0,-10:X}|{1}", a, Convert.ToString(a, 2).PadLeft(10, '0'));

        bool checkB = Convert.ToString(b).IndexOf(".") > 0;
        Console.Write(checkB ? "|{0,10:F2}|" : "|{0,10}|", b);

        bool checkC = Convert.ToString(c).IndexOf(".") > 0;
        Console.WriteLine(checkC ? "{0,-10:0.000}|" : "{0,-10}|", c);

    }
}