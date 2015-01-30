using System;
    class P6BiggestofFiveNumbers
    {
        static void Main()
        {
            double maxnum = double.MinValue;
            double[] num = new double[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (maxnum <= num[i])
                {
                    maxnum = num[i];
                }
            }
            Console.WriteLine(maxnum);
        }
    }

