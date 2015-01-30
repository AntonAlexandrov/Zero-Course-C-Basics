using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            string companyName = "My Company";
            string companyAddress = "Slaveikov Street, Sofia";
            string companyPhone = "359 884 3232";
            string faxNum = "323 315";
            string web = "mysite.com";
            string managerFirstName = "Peter";
            string managerLastName = "Dimov";
            int managerAge = 51;
            string managerNum = "359 321 32311";
            Console.WriteLine("Company Name: {0}", companyName);
            Console.WriteLine("Company Address: {0}", companyAddress);
            Console.WriteLine("Company Phone: {0}", companyPhone);
            Console.WriteLine("Company Fax: {0}", faxNum);
            Console.WriteLine("Company Web Site: {0},", web);
            Console.WriteLine("Manager First Name: {0}", managerFirstName);
            Console.WriteLine("Manager Last Name: {0}", managerLastName);
            Console.WriteLine("Manager Age: {0}", managerAge);
            Console.WriteLine("Manager Phone: {0}", managerNum);

        }
    }
}
