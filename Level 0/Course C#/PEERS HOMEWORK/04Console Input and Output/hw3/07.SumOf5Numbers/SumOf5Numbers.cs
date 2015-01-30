using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            decimal sum = 0.00m;
            string[] numbersAsStrings = input.Split(' ');
            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                sum += decimal.Parse(numbersAsStrings[i]);
            }
            Console.WriteLine(sum);

            }
        }
    }
