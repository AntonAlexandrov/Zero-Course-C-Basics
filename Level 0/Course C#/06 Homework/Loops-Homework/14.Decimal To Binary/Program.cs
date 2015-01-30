using System;

class DecimalToBinary
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());

        string outputNum = String.Empty;
        int reminder;

        while (inputNum > 0)
        {
            reminder = (int)inputNum % 2;
            inputNum /= 2;
            outputNum = reminder.ToString() + outputNum;
        }

        Console.WriteLine(outputNum);
    }
}