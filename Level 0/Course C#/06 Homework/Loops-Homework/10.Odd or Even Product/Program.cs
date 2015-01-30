using System;

class Product
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string[] numbers = inputLine.Split(' ');

        int oddProduct = 1;
        int evenProduct = 1;

        for(int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0) oddProduct *= int.Parse(numbers[i]);
            else evenProduct *= int.Parse(numbers[i]);
        }

        if(evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}