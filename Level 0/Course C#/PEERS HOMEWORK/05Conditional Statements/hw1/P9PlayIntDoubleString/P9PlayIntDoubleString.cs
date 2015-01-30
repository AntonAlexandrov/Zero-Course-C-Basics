using System;
class P9PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int a = int.Parse(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("Please enter an int:");
            int num = int.Parse(Console.ReadLine());
            num += 1;
            Console.WriteLine(num);
        }
        if (a == 2)
        {
            Console.WriteLine("Please enter a double:");
            double num = double.Parse(Console.ReadLine());
            num += 1;
            Console.WriteLine(num);
        }
        if (a == 3)
        {
            Console.WriteLine("Please enter a string:");
            string s = Console.ReadLine();
            s += "*";
            Console.WriteLine(s);
        }
    }
}

