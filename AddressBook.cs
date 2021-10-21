using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookProgram
{
    class AddressBook
    {

        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string firstname, string lastname, string address, string city,
            string state, string zip, string phone, string email)
        {
            Address addr = new Address(firstname, lastname, address, city,
                state, zip, phone, email);

            Address result = find(firstname);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Address find(string firstname)
        {
            Address addr = addresses.Find((a) => a.firstname == firstname);
            return addr;
        }

    }
}
