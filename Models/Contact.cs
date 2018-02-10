using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _searchName;
        private int _id;
        private string _phoneNumber;
        private Address _address;

        private static List<Contact> _instances = new List<Contact>{};

        public Contact(string name, string phone)
        {
            _name = name;
            _searchName = _name.ToLower();
            _instances.Add(this);
            _id = _instances.Count;
            _phoneNumber = phone;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetSearchName()
        {
            return _searchName;
        }

        public void SetSearchName()
        {
            _searchName = _name.ToLower();
        }

        public string GetPhone()
        {
            return _phoneNumber;
        }

        public void SetPhone(string phone)
        {
            _phoneNumber = phone;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public void SetAddress(Address address)
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
