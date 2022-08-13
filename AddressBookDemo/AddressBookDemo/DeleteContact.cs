using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class DeleteContact
    {
        public string Firstname;
        public string Lastname;
        public string Address;
        public string City;
        public string State;
        public string Postalcode;
        public string PhoneNumber;
        public string email;
        public static List<DeleteContact> People = new List<DeleteContact>();
        public static void NewContact()
        {
            DeleteContact person = new DeleteContact();
            Console.Write("Enter First Name: ");
            person.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.Lastname = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City name: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State name: ");
            person.State = Console.ReadLine();

            Console.Write("Enter the Postal Code: ");
            person.Postalcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter the Email ID: ");
            person.email = Console.ReadLine();
            People.Add(person);
        }
        public static void AllDetails(DeleteContact person)
        {
            Console.WriteLine("First Name: " + person.Firstname);
            Console.WriteLine("Last Name: " + person.Lastname);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Postal Code: " + person.Postalcode);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Email ID: " + person.email);

        }
        public static void ListAllContacts()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("People in your Address Book:\n");
            Console.ResetColor();
            foreach (var person in People)
            {
                AllDetails(person);
            }

        }
        public static void Delete()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press 1 If you want to Delete any Contact in the Address Book");
            Console.ResetColor();
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Enter the First Name of the Person you want to delete");
                    string firstname = Console.ReadLine();
                    DeleteContact person = People.Find(x => x.Firstname.ToLower() == firstname.ToLower());
                    DeleteContact findperson = People.FirstOrDefault(x => x.Firstname.ToLower() == firstname.ToLower());
                    if (person == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That person U entered is not found\n");
                        Console.ResetColor();
                        DeleteContact.Delete();
                    }
                    People.Remove(findperson);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nPerson removed. Press any key to continue.");
                    Console.ResetColor();
                    Console.ReadKey();
                    ListAllContacts();
                    break;
                default:
                    Console.WriteLine("Thanku!!!");
                    break;
            }
        }
    }
}