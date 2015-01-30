using System;
class P8DigitasWord
{
    static void Main(string[] args)
    {
        int a = -1;
        bool ia = false;
        string b = Console.ReadLine();
        ia = int.TryParse(b, out a);
        if (ia == false || a<0 || a>9 )
        {         
            Console.WriteLine("not a digit");
        }
        else
        {     
        string[] digit = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };       
        Console.WriteLine(digit[a]);   
        }
    }
}

