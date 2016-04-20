using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            string companyName= Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string firstNameManager = Console.ReadLine();
            string lastNameManager = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string phoneNumberManager = Console.ReadLine();

            if (faxNumber == string.Empty)
            {
                faxNumber = "(no fax)";
            }
            Console.WriteLine("{0}{1}Address: {2}{1}Tel. {3}{1}Fax: {4}{1}Web site: {5}{1}Manager: {6} {7} (age: {8}, tel. {9})", companyName, Environment.NewLine, companyAddress, phoneNumber, faxNumber, webSite, firstNameManager, lastNameManager, age, phoneNumberManager);
        }
    }
}
