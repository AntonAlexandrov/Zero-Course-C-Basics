using System;

class BitInverter
{
    static int BitAtPosition(int number, int position) // returns the value of the bit at position
    {            
        int nRightP = number >> position;    
        int bitValue = nRightP & 1;
        return bitValue;
    }
    static void Main()
    {
        int n, step;

        n = int.Parse(Console.ReadLine());
        step = int.Parse(Console.ReadLine());

        int[] inputedNumbers = new int[n];
        int mask;

        for(int i = 0; i < n; i++) //write down all inputed numbers
        {
            inputedNumbers[i] = int.Parse(Console.ReadLine());
        }

        int index = 0;
        int currentStep = 1;
        int bitIndex;
        while(index < n)
        {
            if(currentStep <= 8)
            {
                bitIndex = 8 - currentStep; //tells the position of the bit we have to change in one number
                if(BitAtPosition(inputedNumbers[index], bitIndex) == 0)
                {
                    mask = 1 << bitIndex;
                    inputedNumbers[index] |= mask; 
                }
                else if(BitAtPosition(inputedNumbers[index], bitIndex) == 1)
                {
                    mask = ~(1 << bitIndex);
                    inputedNumbers[index] &= mask;
                }
                currentStep += step;
            }
            else
            {
                currentStep -= 8;
                index++;
            }
        }

        for(int i = 0; i < n; i++) //output the inverted numbers
        {
            Console.WriteLine(inputedNumbers[i]);
        }

    }
}