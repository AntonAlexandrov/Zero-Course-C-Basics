using System;

class Cables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cables = new int[n];

        string lenghtWord;

        //input cables lenghts
        for(int i = 0; i < n; i++)
        {
            cables[i] = int.Parse(Console.ReadLine());
            lenghtWord = Console.ReadLine();
            if(lenghtWord == "meters")
            {
                cables[i] *= 100;
            }
        }

        //calculate joined cable lenght
        int totalCableLenght = 0;
        int joinedCableCount = 0;

        for(int i = 0; i < n; i++)
        {
            if(cables[i] >= 20)
            {
                totalCableLenght += cables[i];
                joinedCableCount++;
            }
        }

        totalCableLenght -= (joinedCableCount - 1) * 3;

        int readyCabels = totalCableLenght / 504;
        int remainder = totalCableLenght % 504;

        Console.WriteLine(readyCabels);
        Console.WriteLine(remainder);
    }
}