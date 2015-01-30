using System;

class Numbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double min, max, sum, average;
        double inputNum = double.Parse(Console.ReadLine());

        min = max = sum = average = inputNum;

        for(int i = 0; i < n - 1; i++)
        {
            inputNum = double.Parse(Console.ReadLine());
            if(min > inputNum)
            {
                min = inputNum;
            }
            if(max < inputNum)
            {
                max = inputNum;
            }
            sum += inputNum;
        }
        average = sum / n;

        Console.WriteLine(min);
        Console.WriteLine(max);
        Console.WriteLine(sum);
        Console.WriteLine(average);
    }
}