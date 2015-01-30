using System;

class DectoHex
{
    static void Main()
    {
        long inputNum = long.Parse(Console.ReadLine());

        string outputStr = String.Empty;
        int reminder;

        while(inputNum > 0)
        {
            reminder = (int)(inputNum % 16);
            inputNum /= 16;

            switch(reminder)
            {
                case 10: outputStr = 'A' + outputStr; break;
                case 11: outputStr = 'B' + outputStr; break;
                case 12: outputStr = 'C' + outputStr; break;
                case 13: outputStr = 'D' + outputStr; break;
                case 14: outputStr = 'E' + outputStr; break;
                case 15: outputStr = 'F' + outputStr; break;
                default: outputStr = reminder.ToString() + outputStr; break;
            }

        }
        Console.WriteLine(outputStr);
    }
}