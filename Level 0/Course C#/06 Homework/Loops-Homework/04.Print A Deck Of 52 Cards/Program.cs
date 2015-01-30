using System;

class Deck
{
    static void Main()
    {
        //3, 4, 5, 6

        for(int i = 2; i <= 81; i++)
        {
            for(int j = 3; j <= 6; j++)
            {
                switch(i)
                {
                    case 2: Console.Write("{0}{1} ", i, (char)j); break;
                    case 3: Console.Write("{0}{1} ", i, (char)j); break;
                    case 4: Console.Write("{0}{1} ", i, (char)j); break;
                    case 5: Console.Write("{0}{1} ", i, (char)j); break;
                    case 6: Console.Write("{0}{1} ", i, (char)j); break;
                    case 7: Console.Write("{0}{1} ", i, (char)j); break;
                    case 8: Console.Write("{0}{1} ", i, (char)j); break;
                    case 9: Console.Write("{0}{1} ", i, (char)j); break;
                    case 10: Console.Write("{0}{1} ", i, (char)j); break;
                    case 65: Console.Write("{0}{1} ", (char)i, (char)j); break;
                    case 74: Console.Write("{0}{1} ", (char)i, (char)j); break;
                    case 75: Console.Write("{0}{1} ", (char)i, (char)j); break;
                    case 81: Console.Write("{0}{1} ", (char)i, (char)j); break;
                    default: break;
                }
            }
        }
    }
}