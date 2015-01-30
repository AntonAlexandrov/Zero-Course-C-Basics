using System;

class DNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        int charsOnRow = 1;
        bool increaseChars = true;

        for(int i = 0; i < n; i++)
        {
            Console.Write(new string('.', (7 - charsOnRow) / 2));
            for (int j = 0; j < charsOnRow; j++ )
            {
                Console.Write(letter);
                letter++;
                if(letter > 71)
                {
                    letter = (char)65;
                }
            }
            Console.WriteLine(new string('.', (7 - charsOnRow) / 2));

            if(increaseChars)
            {
                charsOnRow += 2;
                if (charsOnRow > 7)
                {
                    charsOnRow = 5;
                    increaseChars = false;
                }
            }
            else
            {
                charsOnRow -= 2;
                if (charsOnRow < 1)
                {
                    charsOnRow = 1;
                    increaseChars = true;
                }
            }

        }
    }
}