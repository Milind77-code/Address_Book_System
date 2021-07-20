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
            Contact person = new Contact();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Address = address;
            person.City = city;
            person.State = state;
            person.Zip = zip;
            person.PhoneNumber = phoneNumber;
            person.Email = email;

            Contacts.Add(person);
        }

        /// <summary>
        /// Method to display contact
        /// </summary>
        public void ShowContact()
        {
            if (Contacts.Count >= 1)
            {
                foreach (Contact person in Contacts)
                {
                    Console.WriteLine("First Name : " + person.FirstName);
                    Console.WriteLine("Last Name : " + person.LastName);
                    Console.WriteLine("Address : " + person.Address);
                    Console.WriteLine("City : " + person.City);
                    Console.WriteLine("State : " + person.State);
                    Console.WriteLine("Zip : " + person.Zip);
                    Console.WriteLine("Phone Number : " + person.PhoneNumber);
                    Console.WriteLine("Email : " + person.Email);
                }
            }
            else
                Console.WriteLine("No contacts to Display.....");
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

            foreach (Contact person in Contacts)
            {
                if (person.FirstName.Equals(fName))
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
                                person.FirstName = firstName;
                                Console.WriteLine("First Name Edited Successfully.");
                                break;

                            case 2:
                                Console.WriteLine("Edit Last Name :- ");
                                string lastName = Console.ReadLine();
                                person.LastName = lastName;
                                Console.WriteLine("Last Name Edited Successfully.");
                                break;

                            case 3:
                                Console.WriteLine("Edit Address :- ");
                                string address = Console.ReadLine();
                                person.Address = address;
                                Console.WriteLine("Address Edited Successfully.");
                                break;

                            case 4:
                                Console.WriteLine("Edit City :- ");
                                string city = Console.ReadLine();
                                person.City = city;
                                Console.WriteLine("City Edited Successfully.");
                                break;

                            case 5:
                                Console.WriteLine("Edit State :- ");
                                string state = Console.ReadLine();
                                person.State = state;
                                Console.WriteLine("State Edited Successfully.");
                                break;

                            case 6:
                                Console.WriteLine("Edit Zip :- ");
                                int zip = Convert.ToInt32(Console.ReadLine());
                                person.Zip = zip;
                                Console.WriteLine("Zip Edited Successfully.");
                                break;

                            case 7:
                                Console.WriteLine("Edit Phone Number :- ");
                                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                                person.PhoneNumber = phoneNumber;
                                Console.WriteLine("Phone Number Edited Successfully.");
                                break;

                            case 8:
                                Console.WriteLine("Edit Email :- ");
                                string email = Console.ReadLine();
                                person.Email = email;
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


        /// <summary>
        /// Method to remove person
        /// </summary>
        public void DeletePerson()
        {
            if (Contacts.Count > 0)
            {

                ShowContact();

                Console.Write("Enter the First Name of the person you want to delete :- ");
                string firstName = Console.ReadLine();

                for (int i = 0; i < Contacts.Count; i++)
                {
                    if (Contacts[i].FirstName.Equals(firstName))
                    {
                        Contacts.RemoveAt(i);
                        Console.WriteLine("Person Removed Successfully.");
                    }
                    else
                        Console.WriteLine("Person not found.");
                }
            }
            else
                Console.WriteLine("Contacts Not Found...");
        }
    }
}
