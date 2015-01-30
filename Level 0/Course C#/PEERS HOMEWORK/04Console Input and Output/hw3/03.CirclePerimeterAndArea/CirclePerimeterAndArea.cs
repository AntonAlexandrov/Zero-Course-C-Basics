using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter radius: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter f circle is: {0:F2}", Math.PI * 2 * r);
            Console.WriteLine("The area of circle is: {0:F2}", Math.PI * r * r);


            }
        }
    }
