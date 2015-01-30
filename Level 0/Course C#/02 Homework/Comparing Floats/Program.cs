using System;

class CompareFloats
{
    static void Main()
    {
        double eps = 0.000001;

        double number1 = 5.3;
        double number2 = 6.01;

        if (Math.Abs(number1 - number2) < eps)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}