﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    /// <summary>
    /// Create multiple addressbooks
    /// </summary>
    class MultipleAddressBook
    {
        static Dictionary<string, List<Contact>> dtAddressbook;
        public MultipleAddressBook()
        {
            dtAddressbook = new Dictionary<string, List<Contact>>();
        }
        /// <summary>
        /// ability to return addressBook Dictionary
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, List<Contact>> GetAddressBook()
        {
            return dtAddressbook;
        }
        /// <summary>
        /// create a new address book check for name,
        /// if already exists then, wont create new.
        /// </summary>
        /// <param name="name"></param>
        public bool AddAddressBook(string name)
        {
            //check for addressbook name
            if (dtAddressbook.ContainsKey(name))
            {
                Console.WriteLine("Name already exists!! \n Choose other Name and try Creating new AddressBook.");
                return false;
            }
            else
            {
                List<Contact> contactsList = new List<Contact>();
                Console.WriteLine("address book created successfully....");
                Console.WriteLine("Add new Contacts? \n Press Y/N :");
                char ch = Convert.ToChar(Console.ReadLine());
                ch = Char.ToUpper(ch);
                switch (ch)
                {
                    case 'Y':

                        ContactView contact = new ContactView();
                        Contact newContact = contact.NewContact(contactsList);
                        if (newContact != null)
                        {
                            contactsList.Add(newContact);
                            dtAddressbook.Add(name, contactsList);
                        }
                        else
                            Console.WriteLine("Contact Add failed");
                        break;
                    case 'N':
                        dtAddressbook.Add(name, contactsList);
                        break;
                }
                return true;
            }
        }
        /// <summary>
        /// view all addressbooks present.
        /// </summary>
        public string ViewAddressBooks()
        {
            if (dtAddressbook.Count == 0)
                Console.WriteLine("No AddressBook(s) to Show.");
            if (dtAddressbook.Count >= 1)
            {
                Console.WriteLine("Select AddressBook(s):");
                foreach (var item in dtAddressbook.Keys)
                {
                    Console.WriteLine($"Enter name to Select AddressBook : {item}");
                }
                string addressBookName = Console.ReadLine();
                if (dtAddressbook.ContainsKey(addressBookName))
                    return addressBookName;
                else
                {
                    Console.WriteLine("Invalid Selection made!! \n Try again.");
                    ViewAddressBooks();
                }
            }
            return null;
        }
    }
}
