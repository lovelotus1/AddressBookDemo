using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddContact
    {
        public static void PersonDetails(AddressBookEntry addressBook)
        {
            //Creating a contact with person details(UC1)
            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Your Last Name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Your Home Address : ");
            string address = Console.ReadLine();
            Console.Write("Enter Your City Name : ");
            string city = Console.ReadLine();
            Console.Write("Enter Your State Name : ");
            string state = Console.ReadLine();
            Console.Write("Enter Your Area Postal Code : ");
            int PostalCode = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Phone Number : ");
            long phoneNum = long.Parse(Console.ReadLine());
            Console.Write("Enter Your EmailId : ");
            string emailId = Console.ReadLine();
            //User Data Entry            
            addressBook.AddContactDetails(firstName, lastName, address, city, state, PostalCode, phoneNum, emailId);
            Console.ReadLine();
        }
    }
}