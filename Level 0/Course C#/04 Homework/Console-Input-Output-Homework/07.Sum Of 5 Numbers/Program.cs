using System;

class SumOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        double sum = 0;

        string currentNumber = "";
        input += ' '; //add interval at the end to help with number detection
        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] != ' ')
            {
                currentNumber += input[i]; //add the char to the current number string
            }
            else
            {
                sum += double.Parse(currentNumber); //if the current char is space then convert and reset the string
                currentNumber = "";
            }
        }
        Console.WriteLine(sum);
    }
}