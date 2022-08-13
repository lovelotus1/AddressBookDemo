using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateNewContact
    {
        public string Firstname;
        public string Lastname;
        public string City;
        public string State;
        public string Zipcode;
        public string PhoneNumber;
        public string email;
        public void Show()
        {
            CreateNewContact cc = new CreateNewContact();

            Console.Write("Enter First Name: ");
            cc.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            cc.Lastname = Console.ReadLine();

            Console.Write("Enter City name: ");
            cc.City = Console.ReadLine();

            Console.Write("Enter State name: ");
            cc.State = Console.ReadLine();

            Console.Write("Enter the Zip Code: ");
            cc.Zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            cc.PhoneNumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            cc.email = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDetails of the Person are given below: ");
            Console.ResetColor();
            Console.WriteLine("\nFirst Name: " + cc.Firstname);
            Console.WriteLine("\nLast Name: " + cc.Lastname);
            Console.WriteLine("\nCity: " + cc.City);
            Console.WriteLine("\nState: " + cc.State);
            Console.WriteLine("\nZip Code: " + cc.Zipcode);
            Console.WriteLine("\nPhone Number: " + cc.PhoneNumber);
            Console.WriteLine("\nEmail ID: " + cc.email);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
