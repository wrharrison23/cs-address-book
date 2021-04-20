using System;
using System.Collections.Generic;

namespace address_book
{
  public class AddressBook
  {
    private Dictionary<string, Contact> _contactList { get; set; } = new Dictionary<string, Contact>();

    public void AddContact (string email, Contact contact)
    {
      try
      {
        _contactList.Add(email, contact);
      }
      catch (ArgumentException) {
        Console.WriteLine("An item with the same key has already been added.");
      }
    }
    public Contact GetByEmail(string email)
    {
        if (_contactList.TryGetValue(email, out Contact result))
        {
          return result;
        }
        else
        {
          return null;
        }
  }
  }
}