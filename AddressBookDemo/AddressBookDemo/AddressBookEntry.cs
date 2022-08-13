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
        //Method to create contact(UC1)
        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string emailId, string bookName)
        {
            try
            {
                Contact personDetail = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, emailId);
                if (CheckDuplicateEntry(personDetail, bookName))
                {
                    Console.WriteLine("Person Already Exits In The Book");
                }
                else
                {
                    addressContactBook[bookName].contactList.Add(personDetail);
                    Console.WriteLine("Added Contact SuccessFully\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
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

        public void ViewContact(string personName, string bookName)
        {
            foreach (var contact in addressContactBook[bookName].contactList)
            {
                if (contact.firstName.Equals(personName))
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

        //Method to edit contacts(UC3)
        public void EditContact(string personName, string bookName)
        {
            //Traversing the contact list
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
        //Checking For Duplicate Entry If Any(UC7)
        public bool CheckDuplicateEntry(Contact contact, string bookName)
        {
            List<Contact> book = GetListOfDictctionaryKeys(bookName);
            if (bookName != null)
            {
                if (book.Any(b => b.Equals(contact)))
                    return true;
            }
            return default;
        }

        private List<Contact> GetListOfDictctionaryKeys(string bookName)
        {
            throw new NotImplementedException();
        }
    }
}
    

    