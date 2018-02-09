using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private int _id;
    private string _phoneNumber;
    private string _address;

    private static List<Contact> _instances = new List<Contact>{};

    public Contact(string name, string phone, string address)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count;
      _phoneNumber = phone;
      _address = address;
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
      return _phoneNumber;
    }

    public void SetPhone(string phone)
    {
      _phoneNumber = phone;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string address)
    {
      _address = address;
    }

    public int GetId()
    {
      return _id;
    }

    public static void Delete(int id)
    {
      _instances.RemoveAt(id-1);
      for (int i =0; i < _instances.Count; i++)
      {
        _instances[i]._id = i + 1;
      }
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
