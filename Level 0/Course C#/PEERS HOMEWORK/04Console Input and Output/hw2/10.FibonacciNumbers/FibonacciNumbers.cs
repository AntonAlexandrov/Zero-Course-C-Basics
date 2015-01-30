using System;

class FibonacciNumbers
{
    static void Main()
    {
        int firstNum = 0;
        int secondNum = 1;

        int fiboNum = int.Parse(Console.ReadLine());

        if (fiboNum == 1)
        {
            Console.WriteLine(firstNum);
        }

        if (fiboNum == 2)
        {
            Console.Write(firstNum + " " + secondNum);
        }
        if (fiboNum > 2)
        {
            Console.Write(firstNum + " " + secondNum + " ");
            for (int i = 2; i < fiboNum; i++)
            {
                int otherNum = firstNum;
                firstNum = secondNum;
                secondNum = otherNum + secondNum;
                Console.Write(secondNum + " ");
            }
        }
    }
}