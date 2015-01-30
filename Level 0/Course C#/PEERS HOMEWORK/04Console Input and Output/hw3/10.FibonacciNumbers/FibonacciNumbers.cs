using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            for (long i = 0, previous = 0, current = 1, n = long.Parse(Console.ReadLine()); i < n; i++)
            {
                Console.Write("{0} ", previous);
                var temp = current;
                current += previous;
                previous = temp;
            }
            Console.WriteLine();

        }
    }
}
