using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Address
    {
        private string _street;
        private string _cityState;
        private string _zip;

        public Address(string street, string cityState, string zip)
        {
            _street = street;
            _cityState = cityState;
            _zip = zip;
        }

        public string GetStreet()
        {
            return _street;
        }

        public void SetStreet(string street)
        {
            _street = street;
        }

        public string GetCityState()
        {
            return _cityState;
        }

        public void SetCityState(string cityState)
        {
            _cityState = cityState;
        }

        public string GetZip()
        {
            return _zip;
        }

        public void SetZip(string zip)
        {
            _zip = zip;
        }
    }
}
