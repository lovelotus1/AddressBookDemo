using AddressBook;

Console.WriteLine("====Welcome to Address Book Program====");
//Creating object of AddressBookEntry
AddressBookEntry addressBook = new AddressBookEntry(1);
Contact newContact = AddressBookEntry.CreateContact();
Console.WriteLine("*****-> Details Of Person  <-*****");
Console.WriteLine($"First Name: {newContact.FirstName}");
Console.WriteLine($"Last Name: {newContact.LastName}");
Console.WriteLine($"Address: {newContact.Address}");
Console.WriteLine($"City Name: {newContact.City}");
Console.WriteLine($"State Name: {newContact.State}");
Console.WriteLine($"Postalcode: {newContact.PostalCode}");
Console.WriteLine($"PhoneNumber: {newContact.PhoneNumber}");
Console.WriteLine($"Email: {newContact.Email}");
Console.WriteLine("==========================================================================");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Address book options:\n1:To Add New Entry.\n2:TO Leave.\n");
Console.Write("Option: ");
Console.ResetColor();
string Instruction = Console.ReadLine();
while (true)
{
    if (Instruction.ToLower() == "2")//Checking For Option
    {
        Console.WriteLine("GoodBye!");
        break;
    }
    else if (Instruction.ToLower() == "1")//Checking For Option
    {
        addressBook.AddNewContact();
    }
    else
    {
        Console.WriteLine("Invalid Input!");
    }
}
Console.WriteLine("=========================================================================");
Console.ReadLine();