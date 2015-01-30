using System;

class Pairs
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] inputNumsArray = inputStr.Split(' ');

        int lastSum = int.Parse(inputNumsArray[0]) + int.Parse(inputNumsArray[0+1]);

        int maxDiff = 0;

        for (int i = 2; i < inputNumsArray.Length - 1; i += 2)
        {
            int currentSum = int.Parse(inputNumsArray[i]) + int.Parse(inputNumsArray[i+1]);
            int diff = Math.Abs(lastSum - currentSum);

            maxDiff = Math.Max(diff, maxDiff);
            lastSum = currentSum;
        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value={0}", lastSum);            
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}