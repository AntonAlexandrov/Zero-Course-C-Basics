using System;

class GravityOnMoon
{
    static void Main()
    {
        int weight = int.Parse(Console.ReadLine());

        float moonGravity = weight * 17 / 100.0f;

        Console.WriteLine("Weight on Earth: " + weight);
        Console.WriteLine("Weight on Moon: " + moonGravity);
    }
}