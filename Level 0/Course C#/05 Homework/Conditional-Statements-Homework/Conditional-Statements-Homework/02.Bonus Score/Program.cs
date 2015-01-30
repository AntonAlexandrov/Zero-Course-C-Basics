using System;

class Score
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        if(score < 1 || score > 9)
        {
            Console.WriteLine("invalid score");
        }
        else if (score > 0 && score < 4)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        else if (score > 3 && score < 7)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        else if (score > 6 && score < 10)
        {
            score *= 1000;
            Console.WriteLine(score);
        }
    }
}