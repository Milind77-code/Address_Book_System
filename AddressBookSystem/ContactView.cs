using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static AddressBookSystem.Contact;

namespace AddressBookSystem
{
    interface IOperationalMethods
    {
        public void Listview(List<Contact> contactsList);
        public Contact NewContact(List<Contact> contactsList);
        public void DeleteContact(List<Contact> contactsList);
        public void EditContact(List<Contact> contactsList);
    }
    class ContactView : IOperationalMethods
    {
        public Contact Person3 = new Contact();
        /// <summary>
        /// Display Contact details template.
        /// </summary>
        public void Listview(List<Contact> contactsList)
        {
            try
            {
                if (contactsList.Count == 0)
                    Console.WriteLine("No Contacts to Display");
                else
                {
                    foreach (Contact i in contactsList)
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("--------Contacts--------");
                        Console.WriteLine($"Full Name: {i.FirstName} {i.LastName}");
                        Console.WriteLine($"Phone Number: {i.PhoneNumber}");
                        Console.WriteLine($"Email: {i.Email}");
                        Console.WriteLine($"Address: {i.Address}, \n \t{i.City}, {i.State}, {i.ZipCode}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// New contact method - ask user to enter all details. using console
        /// </summary>
        public Contact NewContact(List<Contact> contactsList)
        {
            try
            {
                //global object 'Person3' is used.//
                CustomInput(Person3, contactsList);
                //validating contact details
                Person3.ValidateContactDetails();
                //adding contact to list
                //contactsList.Add(Person3);
                return Person3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("New contact entry aborted.");
            }
            return null;
        }

        /// <summary>
        /// delete a contact method using an index of list entered by user.
        /// check for contacts available in list
        /// if no contacts display message and end.
        /// else ask for delete using index of list.
        /// </summary>
        public void DeleteContact(List<Contact> contactsList)
        {
            try
            {
                if (contactsList.Count == 0)
                {
                    Console.WriteLine("No Contacts available to Delete");
                }
                else
                {
                    int i = 0;
                    Console.WriteLine("Select the contact you want to Delete : ");
                    foreach (Contact contacts in contactsList)
                    {
                        Console.WriteLine($" Press ({i}) for {contacts.FirstName}");
                        i++;
                    }
                    int sel = Convert.ToInt32(Console.ReadLine());
                    while (sel >= i || sel < 0)
                    {
                        Console.WriteLine("invalid choice made,");
                        Console.WriteLine("enter a valid choice");
                        sel = Convert.ToInt32(Console.ReadLine());
                    }
                    contactsList.RemoveAt(sel);
                    Console.WriteLine("Contact deleted successfully!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// edit a contact using a index ask ask for details and replace
        /// the details with appropriate details.
        /// </summary>
        public void EditContact(List<Contact> contactsList)
        {
            try
            {
                if (contactsList.Count == 0)
                {
                    Console.WriteLine("No Contacts available to Edit");
                }
                else
                {
                    int i = 0;
                    Console.WriteLine("Select the contact you want to Edit : ");
                    foreach (Contact contacts in contactsList)
                    {

                        Console.WriteLine($" press {i} for {contacts.FirstName}");
                        i++;
                    }
                    int sel = Convert.ToInt32(Console.ReadLine());
                    while (sel >= i || sel < 0)
                    {
                        Console.WriteLine("invalid choice made,");
                        Console.WriteLine("enter a valid choice");
                        sel = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("-------Before editing-------");
                    CustomView(sel, contactsList);
                    Console.WriteLine("Enter new Details");
                    //global object 'Person3' is used.//
                    CustomInput(Person3, contactsList);
                    //validating contact details
                    Person3.ValidateContactDetails();
                    //removing contact
                    contactsList.RemoveAt(sel);
                    //adding new details of contact at list
                    contactsList.Insert(sel, Person3);
                    Console.WriteLine();
                    Console.WriteLine("Contact edit successful!!");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("-------After editing-------");
                    CustomView(sel, contactsList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// custom display template for edit contact 
        /// sel- is parameter that passes appropriate selected contact index.
        /// </summary>
        /// <param name="sel"></param>
        private void CustomView(int sel, List<Contact> contactsList)
        {
            Console.WriteLine();
            Console.WriteLine("Contacts");
            Console.WriteLine($"Full Name: {contactsList[sel].FirstName} {contactsList[sel].LastName}");
            Console.WriteLine($"Phone Number: {contactsList[sel].PhoneNumber}");
            Console.WriteLine($"Email: {contactsList[sel].Email}");
            Console.WriteLine($"Address: {contactsList[sel].Address}, \n \t{contactsList[sel].City}, {contactsList[sel].State}, {contactsList[sel].ZipCode}");
            Console.WriteLine();
        }

        public void CustomInput(Contact Person, List<Contact> contactsList)
        {
            Console.WriteLine("--------Add a New Contact--------");
            Console.WriteLine( );
            Console.WriteLine("Enter First Name: ");
            Person.FirstName = Console.ReadLine();
            //ability to check for duplicate entry of same person in particular addressBook
            foreach (Contact contacts in contactsList)
            {
                while (contacts.FirstName.Contains(Person.FirstName))
                {
                    Console.WriteLine("Name already exists in Contacts \n enter new name: ");
                    Person.FirstName = Console.ReadLine();
                }
            }
            Console.WriteLine("Enter Last Name: ");
            Person.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Person.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            Person.City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            Person.State = Console.ReadLine();
            Console.WriteLine("Enter ZipCode: ");
            var input = Console.ReadLine();
            while (true)
            {
                if (Int32.TryParse(input, out _))
                {
                    Person.ZipCode = Convert.ToInt32(input);
                    break;
                }
                else
                {
                    Console.WriteLine("invalid Input!! try again.");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Enter Phone Number: ");
            input = Console.ReadLine();
            while (true)
            {
                if (Int64.TryParse(input, out _))
                {
                    Person.PhoneNumber = Convert.ToInt64(input);
                    break;
                }
                else
                {
                    Console.WriteLine("invalid Input!! try again.");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine("Enter Email: ");
            Person.Email = Console.ReadLine();
        }
        /// <summary>
        /// ability to import contacts from a file
        /// </summary>
        /// <param name="addressBookName"></param>
        /// <param name="addressBook"></param>
        public void ImportContacts(string addressBookName, Dictionary<string, List<Contact>> addressBook)
        {
            List<Contact> contactsList = addressBook[addressBookName];
            string filepath = @"C:\Users\Milind\OneDrive\Desktop\all Programs\Address_Book_System\AddressBookSystem\ContactsCSVFile.csv";
            if (File.Exists(filepath))
            {
                string[] contactsArray = File.ReadAllLines(filepath);
                for (int i = 1; i < contactsArray.Length; i++)
                {
                    Contact contact = new Contact();
                    string[] data = contactsArray[i].Split(',');
                    contact.FirstName = data[0];
                    contact.LastName = data[1];
                    contact.Address = data[2];
                    contact.City = data[3];
                    contact.State = data[4];
                    contact.ZipCode = Convert.ToInt32(data[5]);
                    contact.PhoneNumber = Convert.ToInt64(data[6]);
                    contact.Email = data[7];
                    contact.ValidateContactDetails();
                    contactsList.Add(contact);
                }
                addressBook[addressBookName] = contactsList;
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
        }
        /// <summary>
        /// ability to Export contacts to a file
        /// </summary>
        /// <param name="contactsList"></param>
        public void ExportContacts(List<Contact> contactsList)
        {
            string[] contactArray = new string[contactsList.Count];
            string filepath = @"C:\Users\Milind\OneDrive\Desktop\all Programs\Address_Book_System\AddressBookSystem\ContactsCSVFile.csv";
            if (File.Exists(filepath))
            {
                for (int i = 0; i < contactsList.Count; i++)
                {
                    Contact contact = contactsList[i];
                    contactArray[i] = contact.FirstName + ',' + contact.LastName + ',' + contact.Address + ',' + contact.City + ',' + contact.State + ',' + Convert.ToString(contact.ZipCode) + ',' + Convert.ToString(contact.PhoneNumber) + ',' + contact.Email;
                }

                File.AppendAllLines(filepath, contactArray, Encoding.UTF8);
            }
            else
            {
                Console.WriteLine("File not found");
            }

        }
        /// <summary>
        /// ability to read contacts list from json file
        /// </summary>
        /// <param name="contactlist"></param>
        public void GetJsonData(List<Contact> contactlist)
        {
            string filepath = @"C:\Users\Milind\OneDrive\Desktop\all Programs\Address_Book_System\AddressBookSystem\JsonFile.json";
            string jObject = File.ReadAllText(filepath);
            Root root = JsonConvert.DeserializeObject<Root>(jObject);
            contactlist.AddRange(root.contacts);
            Console.WriteLine("Import successfull");
        }
        /// <summary>
        /// ability to write contacts list to json file
        /// </summary>
        /// <param name="contactlist"></param>
        public void SetJsonData(List<Contact> contactlist)
        {
            string filepath = @"C:\Users\Milind\OneDrive\Desktop\all Programs\Address_Book_System\AddressBookSystem\JsonFile.json";
            Contact contact = NewContact(contactlist);
            contactlist.Add(contact);
            Root root = new Root
            {
                contacts = contactlist
            };
            string contactdata = JsonConvert.SerializeObject(root, Formatting.Indented);
            File.WriteAllText(filepath, contactdata);
            Console.WriteLine("Emport successfull");
        }
    }
}
