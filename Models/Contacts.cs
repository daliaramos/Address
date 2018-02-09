using System;
using System.Collections.Generic;


namespace Contacts.Models
  {
    public class Contact
    {
      private string _name;
      private int _phone;
      private int _address;
      private static List<Contact> _instances = new List<Contact>{};


    public Contact(string name, int phone, int address)
    {
      _name = name;
      _phone = phone;
      _address = address;
      instances(this);
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public void SetPone(int phone)
    {
      _phone = phone;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(int address)
    {
      _address = address;
    }

    public static List<contact> GetAll()
    {
      return _instances;
    }
    


  }
  }
