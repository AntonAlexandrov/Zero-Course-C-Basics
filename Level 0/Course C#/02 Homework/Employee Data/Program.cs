using System;

class Employee
{
    static void Main()
    {
        string firstName = "Ulian";
        string lastName = "Vidinov";
        sbyte age = 18;
        char gender = 'm';
        string personalID = "0207114506";
        uint uniqueENumber = 275604369;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Male or female: " + gender);
        Console.WriteLine("Personal ID number: " + personalID);
        Console.WriteLine("Unique employee number: " + uniqueENumber);
    }
}