using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        // Declaring and initializing list with model class
        List<Contact> Contacts = new List<Contact>();

        /// <summary>
        /// Method to add contact details to list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zip"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        public void AddContact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            Contact C = new Contact();
            C.FirstName = firstName;
            C.LastName = lastName;
            C.Address = address;
            C.City = city;
            C.State = state;
            C.Zip = zip;
            C.PhoneNumber = phoneNumber;
            C.Email = email;

            Contacts.Add(C);
        }

        /// <summary>
        /// Method to display contact
        /// </summary>
        public void ShowContact()
        {
            foreach (Contact C in Contacts)
            {
                Console.WriteLine("First Name : " + C.FirstName);
                Console.WriteLine("Last Name : " + C.LastName);
                Console.WriteLine("Address : " + C.Address);
                Console.WriteLine("City : " + C.City);
                Console.WriteLine("State : " + C.State);
                Console.WriteLine("Zip : " + C.Zip);
                Console.WriteLine("Phone Number : " + C.PhoneNumber);
                Console.WriteLine("Email : " + C.Email);
            }
        }
    }
}
