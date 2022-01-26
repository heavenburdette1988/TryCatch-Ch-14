using System;
using System.Collections.Generic;

namespace addressBook{


public class Contact{



public string FirstName {get; set;}
public string LastName {get; set;}
public string Email {get; set;}
public string Address {get; set;}

public string FullName {
    get {
        return $"{FirstName} {LastName}";
    }
}

}


public class AddressBook
  {
    private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

    public void AddContact(Contact person)
    {
      _contactList[person.Email] = person;
    }

    public Contact GetByEmail(string email)
    {
      return _contactList[email];
    }
  }


}