using System;

class SumOfElements
{
    static void Main()
    {
        string currentNumberStr = "";
        double number;
        double biggestNumber = 0;//all inputed integers will be non-negative
        double sumOfNs = 0;

        string inputStr = Console.ReadLine();
        inputStr += ' ';//add space in the end for easier operating later on

        for (int i = 0; i < inputStr.Length; i++)
        {
            if (inputStr[i] != ' ')
            {
                currentNumberStr += inputStr[i];
            }
            else
            {
                number = uint.Parse(currentNumberStr);
                sumOfNs += number;//add all the numbers to the sum
                currentNumberStr = "";
                if (biggestNumber < number)
                {
                    biggestNumber = number;
                }
            }
        }

        if (sumOfNs - biggestNumber == biggestNumber)
        {
            Console.WriteLine("Yes, sum={0}", biggestNumber);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(biggestNumber - (sumOfNs - biggestNumber)));
        }
    }
}