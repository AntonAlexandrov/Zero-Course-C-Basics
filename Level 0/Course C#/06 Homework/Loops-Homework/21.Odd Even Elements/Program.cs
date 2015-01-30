using System;

class Elements
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string[] numbers = inputStr.Split(' ');

        bool sufficientOddData = numbers.Length > 0;
        bool sufficientEvenData = numbers.Length > 1;

        if (inputStr == "")
        {
            // Known issue: split on empty string returns 1 token ""
            numbers = new string[0];
            sufficientOddData = false;
        }    

        decimal oddSum = 0, oddMin = 0, oddMax = 0;

        if (sufficientOddData)
        {
            oddSum = 0;
            oddMin = decimal.Parse(numbers[0]); oddMax = decimal.Parse(numbers[0]);
        }

        decimal evenSum = 0, evenMin = 0, evenMax = 0;

        if (sufficientEvenData)
        {
            evenSum = 0;
            evenMin = decimal.Parse(numbers[1]); evenMax = decimal.Parse(numbers[1]);
        }

        for(int i = 0; i < numbers.Length; i++)
        {
            if(i % 2 == 0)
            {
                oddSum += decimal.Parse(numbers[i]);
                if(oddMin > decimal.Parse(numbers[i]))
                {
                    oddMin = decimal.Parse(numbers[i]);
                }
                if (oddMax < decimal.Parse(numbers[i]))
                {
                    oddMax = decimal.Parse(numbers[i]);
                }
            }
            else
            {
                evenSum += decimal.Parse(numbers[i]);
                if (evenMin > decimal.Parse(numbers[i]))
                {
                    evenMin = decimal.Parse(numbers[i]);
                }
                if (evenMax < decimal.Parse(numbers[i]))
                {
                    evenMax = decimal.Parse(numbers[i]);
                }
            }
        }

        if (sufficientOddData && sufficientEvenData)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
        else if(sufficientOddData)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else if (sufficientEvenData)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                (double)evenSum, (double)evenMin, (double)evenMax);
        }
        else
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }

    }
}