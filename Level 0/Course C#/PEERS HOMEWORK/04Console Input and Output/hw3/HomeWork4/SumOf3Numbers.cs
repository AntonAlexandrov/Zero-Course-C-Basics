using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("Enter your first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter your third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of these numbers is " + (firstNumber + secondNumber + thirdNumber));
        }
    }
}
