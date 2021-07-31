using System;

namespace AddressBookSystem
{
    class Program
    {
        
        // Address book program -  able to Add multiple addressbook with unique name for addressBook
        static void Main()
        {
            Console.WriteLine("<--------Welcome to Address Book System-------->");
            Console.WriteLine("------------------------------------------------");

            // creating object
            Display display = new Display();
            display.DisplayChoiceAddressBook();
     

        }
    }
}