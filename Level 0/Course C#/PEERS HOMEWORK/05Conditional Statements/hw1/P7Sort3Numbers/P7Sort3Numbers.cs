﻿using System;
class P7Sort3Numbers
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        if (num1 >= num2 &&  num2>=num3) 
        {
            Console.WriteLine("{0} {1} {2}",num1,num2,num3);
        }
        else
        {
            if (num1 >= num3 && num3 >= num2)
            {
                Console.WriteLine("{0} {1} {2}", num1, num3, num2);
            }
        }

        if (num2 >= num1 && num1 >= num3)
        {
            Console.WriteLine("{0} {1} {2}", num2, num1, num3);
        }
        else
        {
            if (num2 >= num3 && num3 >= num2)
            {
                Console.WriteLine("{0} {1} {2}", num2, num3, num1);
            }
        }
        if (num3 >= num1 && num1 >= num2)
        {
            Console.WriteLine("{0} {1} {2}", num3, num1, num2);
        }
        else
        {
            if (num3 >= num2 && num2 >= num1)
            {
                Console.WriteLine("{0} {1} {2}", num3, num2, num1);
            }
        }
    }
}
