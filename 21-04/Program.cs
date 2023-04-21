using System;
using System.Collections.Generic;
using System.Collections;

namespace DefCoding
{
    class Program
    {
      public  static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to contact list");
                Console.WriteLine();
                List<Contact> contacts = new List<Contact>();
                while (true)
                {
                    Console.WriteLine("choose an option");




                    Console.WriteLine("1. Add a contact");

                    Console.WriteLine("2. View all contacts");

                    Console.WriteLine("3. Search for a contact");

                    Console.WriteLine("4. Exit");


                    string optionString = Console.ReadLine();


                    if (!int.TryParse(optionString, out int option))

                    {

                        throw new ArgumentException("Invalid option. Please enter a number.");

                    }


                    switch (option)

                    {

                        case 1:

                            AddContact(contacts);

                            break;

                        case 2:

                            ViewContacts(contacts);

                            break;

                        case 3:

                            SearchContacts(contacts);

                            break;

                        case 4:

                            Console.WriteLine("Goodbye!");

                            return;

                        default:

                            Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");

                            break;

                    }

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine($"An error occurred: {ex.Message}");

            }

            finally

            {

                Console.WriteLine("Program finished.");

            }

        }


        static void AddContact(List<Contact> contacts)

        {

            try

            {

                Console.WriteLine("Enter the contact's name:");

                string name = Console.ReadLine().Trim();


                if (string.IsNullOrWhiteSpace(name))

                {

                    throw new ArgumentException("Name cannot be empty.");

                }


                Console.WriteLine("Enter the contact's email address:");

                string email = Console.ReadLine().Trim();


                if (string.IsNullOrWhiteSpace(email))

                {

                    throw new ArgumentException("Email cannot be empty.");

                }
                

                Console.WriteLine("Enter the contact's phone number:");

                string phone = Console.ReadLine().Trim();


                if (string.IsNullOrWhiteSpace(phone))

                {

                    throw new ArgumentException("Phone number cannot be empty.");

                }
                //if(string.)
              

                Contact contact = new Contact(name, email, phone);

                contacts.Add(contact);


                Console.WriteLine($"Contact {name} added successfully!");

            }

            catch (Exception ex)

            {

                Console.WriteLine($"An error occurred: {ex.Message}");

            }

        }


        static void ViewContacts(List<Contact> contacts)

        {

            try

            {

                if (contacts.Count == 0)

                {

                    Console.WriteLine("No contacts found.");

                    return;

                }


                Console.WriteLine("All contacts:");

                Console.WriteLine();


                foreach (Contact contact in contacts)

                {

                    Console.WriteLine($"{contact.Name} - {contact.Email} - {contact.Phone}");

                }

            }

            catch (Exception ex)

            {

                Console.WriteLine($"An error occurred: {ex.Message}");

            }

        }


        static void SearchContacts(List<Contact> contacts)

        {

            try

            {

                Console.WriteLine("Enter a search term:");

                string searchTerm = Console.ReadLine().Trim();


                if (string.IsNullOrWhiteSpace(searchTerm))

                {

                    throw new ArgumentException("Search term cannot be empty.");

                }


                List<Contact> matchingContacts = new List<Contact>();


                foreach (Contact contact in contacts)

                {

                    if (contact.Name.Contains(searchTerm) || contact.Email.Contains(searchTerm) || contact.Phone.Contains(searchTerm))

                    {

                        matchingContacts.Add(contact);

                    }

                }


                if (matchingContacts.Count == 0)

                {

                    Console.WriteLine("No matching contacts found.");

                    return;

                }


                Console.WriteLine($"Found {matchingContacts.Count} matching contacts:");

                Console.WriteLine();


                foreach (Contact contact in matchingContacts)
                {

                    Console.WriteLine($"{contact.Name} - {contact.Email} - {contact.Phone}");

                }



            }

            catch (Exception ex)

            {

                Console.WriteLine($"An error occurred: {ex.Message}");

            }

        }

    }


    class Contact

    {

        public string Name { get; }

        public string Email { get; }

        public string Phone { get; }


        public Contact(string name, string email, string phone)

        {

            Name = name;

            Email = email;

            Phone = phone;

        }

    }
}




