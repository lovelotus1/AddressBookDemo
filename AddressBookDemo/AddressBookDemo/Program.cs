using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AddressBook
{
    public class program
    {
        public static string bookName;
        public static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome To Address Book Program");
            //Create Objects
            AddressBookEntry addressBook = new AddressBookEntry();
            while (true)
            {
                Console.WriteLine("1: Add A Default Addressbook" +
                                  "\n2 Add A New Addressbook To Create Contact" +
                                  "\n3 Switch AddressBook To Work On" +
                                  "\n4: Add A New Person Details" +
                                  "\n5: Add Default Contact Details" +
                                  "\n6: View All Person Details" +
                                  "\n7: View Single Person Details" +
                                  "\n8: Edit Person Details" +
                                  "\n9: Delete Person Details" +
                                  "\n10: Show AddressBook" +
                                  "\n11: Search Person By City Or State" +
                                  "\n12: Exit"
                                  );
                Console.Write("Enter The Choice From Above : ");
                bool flag = int.TryParse(Console.ReadLine(), out int userChoice);
                if (flag)
                    switch (userChoice)
                    {
                        case 1:
                            //Creating a default addressbook for storing contact(UC6)
                            bookName = "Home";
                            addressBook.AddAddressBook(bookName);
                            break;
                        case 2:
                            //Creating a new addresbook for storing comtacts(UC6)
                            Console.Write("Enter a New AddressBook Name to Add Another Contact :");
                            string newBookName = Console.ReadLine();
                            addressBook.AddAddressBook(newBookName);
                            bookName = newBookName;
                            break;
                        case 3:
                            //Switching AddressBooks(UC6)
                            Console.Write("Enter The NAme of The AddressBook You Want To Switch To :");
                            string newbookName = Console.ReadLine();
                            addressBook.CheckAddressBook(newbookName);
                            bookName = newbookName;
                            break;
                        case 4:
                            //For adding multiple person(UC5)
                            //Creating a new contact with person Details(UC2)
                            AddContact.PersonDetails(addressBook, bookName);
                            break;
                        case 5:
                            //For adding multiple Person(UC5)
                            //Creating a contact with person details(UC1)
                            AddContact.PersonDetails(addressBook, bookName);
                            break;
                        case 6:
                            addressBook.ViewContact(bookName);
                            break;
                        case 7:
                            //Editing a contact details with given name(UC3)
                            Console.Write("Enter The First Name Exactly To View Contact Records: ");
                            string personName = Console.ReadLine();
                            addressBook.ViewContact(personName, bookName);
                            break;
                        case 8:
                            //Editing a contact details with given name(UC3)
                            Console.Write("Enter The First Name Exactly To Edit Contact Records: ");
                            string fName = Console.ReadLine();
                            addressBook.EditContact(fName, bookName);
                            break;
                        case 9:
                            //Deleting a contact details with given name(UC4)
                            Console.Write("Enter The First Name Exactly To Delete Contact Records : ");
                            string firstName = Console.ReadLine();
                            addressBook.DeleteContact(firstName, bookName);
                            break;
                        case 10:
                            //Refactor to view multiple Address Book to the System.
                            foreach (var result in addressBook.GetAddressBook())
                            {
                                Console.WriteLine(result.Key);
                            }
                            Console.Write("Enter The Name Of The AddressBook From Above List To See Contacts : ");
                            while (true)
                            {
                                bookName = Console.ReadLine();
                                if (!addressBook.GetAddressBook().ContainsKey(bookName))
                                {
                                    Console.WriteLine("Book Name Doesnt Exist");
                                    break;
                                }
                                else
                                {
                                    addressBook.ViewContact(bookName);
                                    break;
                                }
                            }
                            break;
                        case 11:
                            //Taking the input city and state from the user to search the person(UC8)
                            Console.WriteLine("\n1.Search by city \n2.Search by state");
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.Write("Enter name of city to search the person for : ");
                                    addressBook.SearchPersonByCity(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.Write("Enter name of state to search the person from :");
                                    addressBook.SearchPersonByState(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Enter A Right Choice Either 1 or 2");
                                    break;
                            }
                            break;
                        case 12:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter A Right Choice");
                            continue;
                    }
                else
                    Console.WriteLine("Enter Some Input Value");
            }
        }
    }
}