using System;

class P5Biggestof3Nums
{
    static void Main()
    {
        double maxnum = double.MinValue;
        double[] num= new  double[3];
        for (int i = 0; i < 3; i++)
        {
            num[i]= double.Parse(Console.ReadLine());
        } 
        for (int i = 0; i < 3; i++)
		{
            if (maxnum<= num[i])
            {
                maxnum = num[i];
            }   			 
		}
        Console.WriteLine(maxnum);
    }
}
