using System;

class BitsUp
{
    /*static int changeBitInNumber(int number, int position)
    {
        return number |= (1 << position);
    }*/
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        byte[] arrayOfInput = new byte[n];
        for (int i = 0; i < n; i++)
        {
            arrayOfInput[i] = byte.Parse(Console.ReadLine());
        }
        int bitIndex = 1;
        int numberIndex = 0;

        while (numberIndex < n)
        {
            if (bitIndex >= 8)
            {
                bitIndex -= 8;
                numberIndex++;
            }
            else
            {
                arrayOfInput[numberIndex] |= (byte)(1 << 7 - bitIndex);
                bitIndex += step;
            }
        }
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(arrayOfInput[j]);
        }
    }
}