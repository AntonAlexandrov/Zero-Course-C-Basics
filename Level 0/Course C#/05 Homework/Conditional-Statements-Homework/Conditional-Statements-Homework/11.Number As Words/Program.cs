using System;

class NumberWrods
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        string[] numberWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        int hundreds = inputNumber / 100;
        int tenths = (inputNumber / 10) % 10;
        int units = (inputNumber % 10) % 10;

        /*Console.WriteLine("{0}, {1}, {2}", hundreds, tenths, units);*/

        //write the hundreds
        if(hundreds != 0)
        {
            Console.Write("{0} hundred and ", numberWords[hundreds]);
        }
        //write the tenths
        if(tenths > 1)
        {
            if (tenths == 2)
            {
                Console.Write("twenty ");
            }
            else if (tenths == 3)
            {
                Console.Write("thirty ");
            }
            else if (tenths == 5)
            {
                Console.Write("fifty ");
            }
            else if (tenths == 8)
            {
                Console.Write("{0}y ", numberWords[tenths]);
            }
            else
            {
                Console.Write("{0}ty ", numberWords[tenths]);
            }
            //write the units
            if (units != 0)
            {
                Console.WriteLine("{0}", numberWords[units]);
            }
        }
        else if (tenths == 1)
        {
            if(units == 0)
            {
                Console.WriteLine("ten");
            }
            else if(units == 1)
            {
                Console.WriteLine("eleven");
            }
            else if(units == 2)
            {
                Console.WriteLine("twelve");
            }
            else if(units == 3)
            {
                Console.WriteLine("thirteen");
            }
            else if (units == 5)
            {
                Console.WriteLine("fifteen");
            }
            else
            {
                Console.WriteLine("{0}teen", numberWords[units]);
            }
        }
        else
        {
            if (hundreds == 0 && tenths == 0 && units == 0)
            {
                Console.WriteLine(numberWords[0]);
            }
            else if (units != 0)
            {
                Console.WriteLine("{0}", numberWords[units]);
            }
        }
    }
}