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


// Contact  is what we want to return
//We are going to Get it by email
// through the _contactlist in the dictionary
    public Contact GetByEmail(string email)
    {
    
      return _contactList[email];
      
    }
  }

}