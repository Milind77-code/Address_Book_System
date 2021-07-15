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
            string userChoice = "";

            do
            {
                Console.WriteLine("Select an Option :- ");
                Console.WriteLine("Press (1). To add new person");
                Console.WriteLine("Press (2). To edit existing person");
                Console.WriteLine("Press (3). To delete a person");
                Console.WriteLine("Press (4). To view all persons" + "\n");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------");
                
                switch (userInput)
                {
                    case 1:
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
                        Console.WriteLine("Person added successfully...");
                        break;
                    case 2:
                        addressBook.ShowContact();
                        addressBook.EditContact();
                        break;

                    case 3:
                        addressBook.DeletePerson();
                        break;

                    case 4:
                        addressBook.ShowContact();
                        break;
                }
                Console.WriteLine("----------------------------------------------");
                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No??");
                    userChoice = Console.ReadLine().ToUpper();
                    Console.WriteLine("----------------------------------------------");

                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, Please say Yes or No...");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }
    }
}