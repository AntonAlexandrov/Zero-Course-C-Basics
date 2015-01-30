using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double desiredNumber = Math.Max(firstNumber, secondNumber);
            Console.WriteLine(desiredNumber);
        }
    }
}
