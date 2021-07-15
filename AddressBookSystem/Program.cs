using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main()
        {
            // creating object
            AddressBook book = new AddressBook();

            // calls set accessor of the properties
            book.FirstName = "Milind";
            book.LastName = "Dhote";
            book.Address = "Devendra Nager";
            book.City = "Raipur";
            book.State = "chhattisgarh";
            book.Zip = 492001;
            book.PhoneNumber = 8080807777;
            book.Email = "milind77@gmail.com";

            Console.WriteLine("--------Welcome to Address Book System--------");
            Console.WriteLine("----------------------------------------------");
            // displaying values
            Console.WriteLine("First Name :- " + book.FirstName);
            Console.WriteLine("Last Name :- " + book.LastName);
            Console.WriteLine("Address :- " + book.Address);
            Console.WriteLine("City :- " + book.City);
            Console.WriteLine("State :- " + book.State);
            Console.WriteLine("Zip :- " + book.Zip);
            Console.WriteLine("Phone Number :- " + book.PhoneNumber);
            Console.WriteLine("Email :- " + book.Email);
            Console.WriteLine("----------------------------------------------");
        }
    }
}