using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNum = Console.ReadLine();
        long decNum = 0;

        char[] charNum = binaryNum.ToCharArray();
        Array.Reverse(charNum);

        for (int i = 0; i < charNum.Length; i++ )
        {
            if(charNum[i] == '1')
            {
                decNum += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine(decNum);
    }
}