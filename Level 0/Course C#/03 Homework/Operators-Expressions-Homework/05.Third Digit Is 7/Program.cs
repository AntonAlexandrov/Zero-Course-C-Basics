using System;

class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string numberString = number.ToString();

        if (numberString[numberString.Length - 3] == '7')
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}