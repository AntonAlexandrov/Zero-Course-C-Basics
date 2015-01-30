using System;
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
class P2BonusScore
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a < 1 || a > 9)
        {
            Console.WriteLine("invalid score");
        }
        else
        {
            if (a < 4)
            {
                Console.WriteLine(a*10);
            }
            else
            {
                if (a < 7)
                {
                    Console.WriteLine(a*100);
                }
                else
                {
                    Console.WriteLine(a*1000);
                }
            }
        }
    }
}

