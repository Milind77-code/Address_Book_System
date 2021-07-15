using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--------Welcome to Address Book System--------");
            Console.WriteLine("----------------------------------------------");
            
            // creating object
            AddressBook addressBook = new AddressBook();

            // Getting input from user
            Console.Write("Enter your First Name :- ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your Last Name :- ");
            string lastName = Console.ReadLine();

            Console.Write("Enter your Address :- ");
            string address = Console.ReadLine();

            Console.Write("Enter your City :- ");
            string city = Console.ReadLine();

            Console.Write("Enter your State :- ");
            string state = Console.ReadLine();

            Console.Write("Enter your Zip :- ");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Phone Number :- ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter your Email :- ");
            string email = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBook.ShowContact();
            addressBook.EditContact();
            Console.WriteLine("----------------------------------------------");
            addressBook.ShowContact();
            Console.WriteLine("----------------------------------------------");
        }
    }
}