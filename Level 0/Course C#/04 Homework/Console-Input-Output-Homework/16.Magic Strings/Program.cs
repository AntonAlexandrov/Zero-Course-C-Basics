using System;

class MagicStrings
{
    static int Weight(string numberStr)
    {
        int weight = 0;
        for (int i = 0; i < numberStr.Length; i++)
        {
            switch (numberStr[i])
            {
                case 's': weight += 3; break;
                case 'n': weight += 4; break;
                case 'k': weight += 1; break;
                case 'p': weight += 5; break;
            }
        }
   
        return weight;
    }
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] symbols = { 'k', 'n', 'p', 's' };
        bool no = false;

        for (int a = 0; a < symbols.Length; a++)
        {
            for (int b = 0; b < symbols.Length; b++)
            {
                for (int c = 0; c < symbols.Length; c++)
                {
                    for (int d = 0; d < symbols.Length; d++)
                    {
                        string firstN = "" + symbols[a] + symbols[b] + symbols[c] + symbols[d];                        
                        for (int e = 0; e < symbols.Length; e++)
                        {
                            for (int f = 0; f < symbols.Length; f++)
                            {
                                for (int g = 0; g < symbols.Length; g++)
                                {
                                    for (int h = 0; h < symbols.Length; h++)
                                    {
                                        string secondN = "" + symbols[e] + symbols[f] + symbols[g] + symbols[h];
                                        if(Math.Abs(Weight(firstN) - Weight(secondN)) == diff)
                                        {
                                            no = true;
                                            Console.WriteLine(firstN + secondN);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if(!no)
        {
            Console.WriteLine("No");
        }

    }
}