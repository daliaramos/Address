using System;
using System.Collections.Generic;


namespace Contacts.Models
  {
    public class Contact
    {
      private string _name;
      private int _phone;
      private string _street;
      private int _zip;
      private static List<Contact> _instances = new List<Contact>{};


    public Contact(string name, int phone, string street, int zip)
    {
      _name = name;
      _phone = phone;
      _street = street;
      _zip = zip;
      _instances.Add(this);
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }

    public int GetPhone()
    {
      return _phone;
    }
    public void SetPhone(int phone)
    {
      _phone = phone;
    }
    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string street)
    {
      _street = street;
    }

    public int GetZip()
    {
      return _zip;
    }
    public void SetZip(int zip)
    {
      _zip = zip;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
