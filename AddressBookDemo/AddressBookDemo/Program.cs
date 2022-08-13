using AddressBook;

Console.WriteLine("====Welcome to Address Book Program====");
AddressBookEntry addressBook = new AddressBookEntry();
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
Console.ReadLine();