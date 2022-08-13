using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class DefaultContactDetails
    {
        public static void AddPersonContact(AddressBookEntry addressBook, string defaultBookName)
        {
            addressBook.AddContactDetails("Prem", "Kamal", "Daltonganj", "Palamu", "Jharkhand", 822101, 0123456789, "prem156@gmail.com", defaultBookName);
            addressBook.AddContactDetails("Rahul", "kumar", "Daltonganj", "Palamu", "Jharkhand", 822102, 9876543210, "Rahul@gmail.com", defaultBookName);
            addressBook.AddContactDetails("Golu", "Babu", "Sec 5", "Delhi", "NewDelhi", 560032, 2345678910, "Golu@gmail.com", defaultBookName);
        }

        internal static void AddPersonContact(AddressBookEntry addressBook)
        {
            throw new NotImplementedException();
        }
    }
}