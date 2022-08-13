using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookEntry
    {
        List<Contact> addressBook = new List<Contact>();

        internal static Contact CreateContact()
        {
            Contact addNew = new Contact();
            Console.Write("Enter Your First Name:");
            addNew.FirstName = Console.ReadLine();
            Console.Write("Enter Your Last Name:");
            addNew.LastName = Console.ReadLine();
            Console.Write("Enter Your Address:");
            addNew.Address = Console.ReadLine();
            Console.Write("Enter Your City Name:");
            addNew.City = Console.ReadLine();
            Console.Write("Enter Your State Name:");
            addNew.State = Console.ReadLine();
            Console.Write("Enter Your Postalcode:");
            addNew.PostalCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Your Phone Number:");
            addNew.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Your Email:");
            addNew.Email = Console.ReadLine();
            Console.WriteLine("===========================================================================");
            return addNew;

        }
    }
}
