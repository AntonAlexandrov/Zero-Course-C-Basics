using System;

class PrintSystemInfo
{
    static void Main()
    {
        string cName, cAdress, cNumber, fax, website, mFirstName, mLastName, mNumber;
        int mAge;

        cName = Console.ReadLine();
        cAdress = Console.ReadLine();
        cNumber = Console.ReadLine();
        fax = Console.ReadLine();
        website = Console.ReadLine();
        mFirstName = Console.ReadLine();
        mLastName = Console.ReadLine();
        mAge = int.Parse(Console.ReadLine());
        mNumber = Console.ReadLine();

        Console.WriteLine(cName);
        Console.WriteLine("Adress: " + cAdress);
        Console.WriteLine("Tel. " + cNumber);
        Console.WriteLine("Fax:" + fax);
        Console.WriteLine("Website: " + website);
        Console.WriteLine("Manager: {0} {1}, ({2}, Tel. {3})", mFirstName, mLastName, mAge, mNumber);
    }
}