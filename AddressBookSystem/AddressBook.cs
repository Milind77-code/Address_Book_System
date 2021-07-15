using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        // private  variables declared
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _city;
        private string _state;
        private int _zip;
        private long _phoneNumber;
        private string _email;

        // using accessors to get and set the value
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        public int Zip
        {
            get { return this._zip; }
            set { this._zip = value; }
        }
        public long PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
    }
}
