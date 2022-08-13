using AddressBook;

Console.WriteLine("==========Welcome To Address Book Program==========");
Console.Write("Select Number:\n1)AddContacts\n2)EditContact\n3)DeleteContact\n");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new CreateNewContact().Show();
        break;
    case 2:
        EditEntry.NewContact();
        EditEntry.ListAllContact();
        EditEntry.Update();
        break;
    case 3:
        DeleteContact.NewContact();
        DeleteContact.ListAllContacts();
        DeleteContact.Delete();
        break;
    default:
        Console.Write("Please Select Correct Number");
        break;

}