using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    public class AddressBookEntry : IContact
    {
        //Creating a contact list
        private readonly List<Contact> contactList;
        private readonly Dictionary<string, AddressBookEntry> addressContactBook;
        private long phoneNumber;
        private int count;

        public AddressBookEntry()
        {
            contactList = new List<Contact>();
            addressContactBook = new Dictionary<string, AddressBookEntry>();
        }
        //Method of view Contact
        public void ViewContact(string bookName)
        {
            foreach (var contact in addressContactBook[bookName].contactList)
            {
                Console.WriteLine("Person Details {0} ------> ", count);
                Console.WriteLine("First Name : {0} || Last Name : {1}", contact.firstName, contact.lastName);
                Console.WriteLine("Address : {0} ", contact.address);
                Console.WriteLine("City Name : {0} || State Name : {1} || ZipCode : {2}", contact.city, contact.state, contact.Zip);
                Console.WriteLine("Phone Number : {0}", contact.phoneNumber);
                Console.WriteLine("Email Id : {0} ", contact.emailId);
                Console.ReadLine();
                count++;
            }
        }
        internal void AddContactDetails(string? firstName, string? lastName, string? address, string? city, string? state, int zip, long phoneNum, string? emailId, string bookName)
        {
            Contact personDetail = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, emailId);
            addressContactBook[bookName].contactList.Add(personDetail);

        }
        public void ViewContact(string personName, string bookName)
        {
            for (int i = 0; i < addressContactBook[bookName].contactList.Count; i++)
            {
                var contact = addressContactBook[bookName].contactList[i];
                if (contact.firstName == personName)
                {
                    Console.WriteLine("First Name : {0} || Last Name : {1}", contact.firstName, contact.lastName);
                    Console.WriteLine("Address : {0} ", contact.address);
                    Console.WriteLine("City Name : {0} || State Name : {1} || ZipCode : {2}", contact.city, contact.state, contact.Zip);
                    Console.WriteLine("Phone Number : {0}", contact.phoneNumber);
                    Console.WriteLine("Email Id : {0} ", contact.emailId);
                    Console.ReadLine();
                }
            }

        }

        internal void ViewContact()
        {
            throw new NotImplementedException();
        }

        public void EditContact(string personName, string bookName)
        {
            for (int i = 0; i < addressContactBook[bookName].contactList.Count; i++)
            {
                var contact = addressContactBook[bookName].contactList[i];
                EditContactDetails.EditPersonDetails(contact, personName);
            }
        }
        public void DeleteContact(string personName, string bookName)
        {
            for (int i = 0; i < addressContactBook[bookName].contactList.Count; i++)
            {
                var contact = addressContactBook[bookName].contactList[i];
                if (contact.firstName == personName)
                {
                    Console.WriteLine("Record Of {0} Deleted Successfully", contact.firstName);
                    addressContactBook[bookName].contactList.RemoveAt(i);
                }
            }
        }
        //Refactor to add multiple Address Book to the system (UC6)
        public void AddAddressBook(string addBookName)
        {
            var contact = addressContactBook;
            if (contact.ContainsKey(addBookName))
            {
                Console.WriteLine("Book Name Exists ");
            }
            else
            {
                AddressBookEntry addressBook = new AddressBookEntry();
                addressContactBook.Add(addBookName, addressBook);
                Console.WriteLine("AddressBook Created.\n");
            }
        }

        internal void EditContact(string? fName)
        {
            throw new NotImplementedException();
        }

        //For Checking If AddressBook Is Present Or Not(UC6)
        public void CheckAddressBook(string bookName)
        {
            foreach (var contact in addressContactBook)
            {
                if (contact.Key == bookName)
                {
                    Console.WriteLine("Switching To Book Name : " + bookName);
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Write("Book Name Doesnt Exist");
                    Console.ReadLine();
                    break;
                }

            }
        }
        //Returning the bookname with contact values to view(UC6 
        public Dictionary<string, AddressBookEntry> GetAddressBook()
        {
            return addressContactBook;
        }

        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailId)
        {
            throw new NotImplementedException();
        }

        void IContact.ViewContact()
        {
            throw new NotImplementedException();
        }

        void IContact.EditContact(string personName)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(string personName)
        {
            throw new NotImplementedException();
        }
    }
}
    

    