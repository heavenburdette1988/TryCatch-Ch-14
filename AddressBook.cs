using System;
using System.Collections.Generic;

namespace addressBook{


public class AddressBook
  {
    private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

    public void AddContact(Contact person)
    {
        try{
      _contactList.Add(person.Email ,person);
    } 
    catch (ArgumentException)
    {
        Console.Write($"{person.FirstName} has already been added to the address book");
        Console.WriteLine();
    }
    
    }

    public Contact GetByEmail(string email)
    {
      return _contactList[email];
    }
  }

}