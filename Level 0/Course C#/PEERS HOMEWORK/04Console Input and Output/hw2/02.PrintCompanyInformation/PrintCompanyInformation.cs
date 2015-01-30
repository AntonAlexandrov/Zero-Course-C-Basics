using System;

class PrintCompanyInformation
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string companyPhoneNumber = Console.ReadLine();
        string companyFaxNumber = Console.ReadLine();
        string companyWebSite = Console.ReadLine();
        
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerAge = int.Parse(Console.ReadLine());
        string managerPhoneNumber = Console.ReadLine();

        if (companyFaxNumber.Length == 0)
        {
            companyFaxNumber = "(no fax)";
        }

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite);
        Console.WriteLine("Manager: {0} {1} ({2}, {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}