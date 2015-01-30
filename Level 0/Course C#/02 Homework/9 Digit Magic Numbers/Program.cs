using System;

class MagicNumbers
{
    static int CalculateSum(int num1, int num2, int num3) //turn each number to string and then scan its elements 
    {
        string number1 = num1.ToString();
        string number2 = num2.ToString();
        string number3 = num3.ToString();

        string number = number1 + number2 + number3;

        int sum = 0;

        for(int i = 0; i < number.Length; i++) //check if the numbers have the letters 1, 8 or 9 in which case exit the method
        {
            if(number[i] == '0' || number[i] == '8' || number[i] == '9')
            {
                return 0;
            }
        }
        

        for(int i = 0; i < number.Length; i++) //add up the numbers at each place in the string
        {
            sum += (int)number[i] - 48;
        }
        return sum; // returns total sum
    }
    static void Main()
    {
        bool isPossible = false; //is set to true even if 1 number exists
        int sum, diff;

        int num1, num2, num3; //split the magic number to 3 numbers

        sum = int.Parse(Console.ReadLine());
        diff = int.Parse(Console.ReadLine());

        for(num1 = 111; num1 < 778; num1++) //generate magic numbers to meet the 1st requeirment
        {
            num2 = num1 + diff;
            num3 = num2 + diff;

            if(CalculateSum(num1, num2, num3) == sum) //method that calculates the sum
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                isPossible = true;
            }
        }
        if(!isPossible) //if no numbers exist write No to the console
        {
            Console.WriteLine("No");
        }
    }
}