using System;

class HexaToDeci
{
    static void Main()
    {
        string inputNum = Console.ReadLine();

        char[] charNum = inputNum.ToCharArray();
        Array.Reverse(charNum);

        long outputNum = 0;

        for (int i = 0; i < charNum.Length; i++)
        {
            switch(charNum[i])
            {
                case '0': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '1': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '2': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '3': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '4': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '5': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '6': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '7': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '8': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case '9': outputNum += (long)Char.GetNumericValue(charNum[i]) * (long)Math.Pow(16, i); break;
                case 'A': outputNum += 10 * (long)Math.Pow(16, i); break;
                case 'B': outputNum += 11 * (long)Math.Pow(16, i); break;
                case 'C': outputNum += 12 * (long)Math.Pow(16, i); break;
                case 'D': outputNum += 13 * (long)Math.Pow(16, i); break;
                case 'E': outputNum += 14 * (long)Math.Pow(16, i); break;
                case 'F': outputNum += 15 * (long)Math.Pow(16, i); break;
            }
        }

        Console.WriteLine(outputNum);
    }
}