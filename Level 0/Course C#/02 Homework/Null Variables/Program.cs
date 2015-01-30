using System;

class NULLVariables
{
    static void Main()
    {
        int? integer = null;
        double? doubleVar = null;

        Console.WriteLine(integer);
        Console.WriteLine(doubleVar);

        integer += 2;
        doubleVar += null;

        Console.WriteLine(integer);
        Console.WriteLine(doubleVar);
    }
}