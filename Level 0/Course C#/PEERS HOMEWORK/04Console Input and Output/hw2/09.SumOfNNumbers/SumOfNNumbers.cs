using System;
using System.Linq;

class SumOfNNumbers
{
    static void Main()
    {
        // Make new empty array
        double[] numbers;

        // Capture n (number/s) from the console
        int n = int.Parse(Console.ReadLine());

        // Make n number/s of indexes of the double array
        numbers = new double[n];

        // Loop from 0 to n, so we will get n times Console.ReadLine() for input numbers
        for (int i = 0; i < n; i++)
        {
            // Put double number to array
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Make the sum of all indexes in double array
        double sum = numbers.Sum();

        // Print the result
        Console.WriteLine("sum={0}", sum);
    }
}