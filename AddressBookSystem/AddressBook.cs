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
        /// <summary>
        /// Method to edit contact
        /// </summary>
        public void EditContact()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.Write("Enter First Name of the contact to be edited : ");
            string fName = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------");

            foreach (Contact contact in Contacts)
            {
                if (contact.FirstName.Equals(fName))
                {
                    int fieldToBeEdited = 0;
                    while (fieldToBeEdited != 9)
                    {
                        Console.WriteLine("Enter a field to edit :- ");
                        Console.WriteLine("Press (1). to edit First Name");
                        Console.WriteLine("Press (2). to edit Last Name");
                        Console.WriteLine("Press (3). to edit Address");
                        Console.WriteLine("Press (4). to edit City");
                        Console.WriteLine("Press (5). to edit State");
                        Console.WriteLine("Press (6). to edit zip");
                        Console.WriteLine("Press (7). to edit Phone Number");
                        Console.WriteLine("Press (8). to edit Email");
                        Console.WriteLine("Press (9). To Exit");
                        Console.WriteLine("----------------------------------------------");

                        fieldToBeEdited = Convert.ToInt32(Console.ReadLine());

                        switch (fieldToBeEdited)
                        {
                            case 1:
                                Console.WriteLine("Edit First Name :- ");
                                string firstName = Console.ReadLine();
                                contact.FirstName = firstName;
                                Console.WriteLine("First Name Edited Successfully.");
                                break;

                            case 2:
                                Console.WriteLine("Edit Last Name :- ");
                                string lastName = Console.ReadLine();
                                contact.LastName = lastName;
                                Console.WriteLine("Last Name Edited Successfully.");
                                break;

                            case 3:
                                Console.WriteLine("Edit Address :- ");
                                string address = Console.ReadLine();
                                contact.Address = address;
                                Console.WriteLine("Address Edited Successfully.");
                                break;

                            case 4:
                                Console.WriteLine("Edit City :- ");
                                string city = Console.ReadLine();
                                contact.City = city;
                                Console.WriteLine("City Edited Successfully.");
                                break;

                            case 5:
                                Console.WriteLine("Edit State :- ");
                                string state = Console.ReadLine();
                                contact.State = state;
                                Console.WriteLine("State Edited Successfully.");
                                break;

                            case 6:
                                Console.WriteLine("Edit Zip :- ");
                                int zip = Convert.ToInt32(Console.ReadLine());
                                contact.Zip = zip;
                                Console.WriteLine("Zip Edited Successfully.");
                                break;

                            case 7:
                                Console.WriteLine("Edit Phone Number :- ");
                                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                                contact.PhoneNumber = phoneNumber;
                                Console.WriteLine("Phone Number Edited Successfully.");
                                break;

                            case 8:
                                Console.WriteLine("Edit Email :- ");
                                string email = Console.ReadLine();
                                contact.Email = email;
                                Console.WriteLine("Email Edited Successfully.");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid Name...");
                }
            }
        }
    }
}