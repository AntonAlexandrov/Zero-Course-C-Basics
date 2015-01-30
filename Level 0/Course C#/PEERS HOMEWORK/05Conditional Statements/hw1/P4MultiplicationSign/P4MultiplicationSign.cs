using System;
class P4MultiplicationSign
{
    static void Main()
    {
        double[] a = new double[3];
        int n = 0;
        int p = 0;
        for (int i = 0; i < 3; i++)
        {
            a[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 3; i++)
        {
            if (a[i] < 0)
            {
                n = n+1;
            }
            if (a[i] == 0)
            {
                p = p+1;
            }

        }
        if (p != 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (n == 1 || n == 3)
            {
                Console.WriteLine('-');
            }
            else
            {
                Console.WriteLine('+');
            }
        }
    }
}
