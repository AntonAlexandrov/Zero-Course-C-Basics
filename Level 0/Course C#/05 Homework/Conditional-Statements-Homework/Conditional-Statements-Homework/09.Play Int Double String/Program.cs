using System;

class Play
{
    static void Main()
    {
        Console.WriteLine("Please, choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte choice = byte.Parse(Console.ReadLine());

        int inputInt; double inputDouble; string inputString;

        switch(choice)
        {
            case 1:
                {
                    inputInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(inputInt + 1);
                }; break;
            case 2:
                {
                    inputDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(inputDouble + 1);
                }; break;
            case 3:
                {
                    inputString = Console.ReadLine();
                    Console.WriteLine(inputString + '*');
                }; break;
        }
    }
}