using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Collections
{
    class Phone
    {
        private List<Person> phonebook;

        public Phone()
        {
            phonebook = new List<Person>();
        }

        public void AddNumber()
        {
            phonebook.Add(new Person { Name = "Mehemmed", Surname = "Qurbanov", PhoneNumber = "0902256565" });
            phonebook.Add(new Person { Name = "Meryem", Surname = "Aliyeva", PhoneNumber = "1002256565" });
            phonebook.Add(new Person { Name = "HaciAga", Surname = "Ahmedov", PhoneNumber = "1234567890" });
            phonebook.Add(new Person { Name = "Jhon", Surname = "Mark", PhoneNumber = "3334446789" });
            phonebook.Add(new Person { Name = "Nigar", Surname = "Qasimova", PhoneNumber = "010-770-6777" });
        }

        public void AddNewNumber()
        {
            Console.WriteLine("Please enter the Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the Surname:");
            string surname = Console.ReadLine();
            Again:
            Console.WriteLine("Please enter the Phone Number:");
                string phoneNumber = Console.ReadLine();

            phonebook.Add(new Person { Name = name, Surname = surname, PhoneNumber = phoneNumber });

            Console.WriteLine("Number  added");
        }

        public void DeleteNumber()
        {
            Console.WriteLine("Please enter the name or surname for deleting:");
            string searchText = Console.ReadLine();

            Person personToDelete = phonebook.FirstOrDefault(person => person.Name.Contains(searchText) || person.Surname.Contains(searchText));

            if (personToDelete == null)
            {
                Console.WriteLine("No data found in the phonebook. Please choose an option:");
                Console.WriteLine("1.To end deletion              2. To try again");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    return;
                }
                else if (choice == 2)
                {
                    DeleteNumber();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
            else
            {
                Console.WriteLine($"Do you confirm deleting {personToDelete.Name}? (y/n)");

                string confirm = Console.ReadLine();

                if (confirm == "yes")
                {
                    phonebook.Remove(personToDelete);
                    Console.WriteLine("Person  deleted");
                }
                else if (confirm == "no")

                {
                    Console.WriteLine("Delet canceled.");
                }
            }
        }

        public void UpdateNumber()
        {
            Console.WriteLine("Please enter the name or surname of the person you want to update:");
            string searchTerm = Console.ReadLine();

            Person personToUpdate = phonebook.FirstOrDefault(person => person.Name.Contains(searchTerm) || person.Surname.Contains(searchTerm));

            if (personToUpdate == null)
            {
                Console.WriteLine(" Please choose an option:");
                Console.WriteLine("1.To end updating     2.To try again");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    return;
                }
                else if (choice == 2)
                {
                    UpdateNumber();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Ending the process.");
                }
            }
            else
            {
                Console.WriteLine($"Please enter the new phone number (current number: {personToUpdate.PhoneNumber}):");
                string newPhoneNumber = Console.ReadLine();

                personToUpdate.PhoneNumber = newPhoneNumber;
                Console.WriteLine("Number successfully updated!");
            }
        }

        public void ListPhonebook()
        {
            Console.WriteLine("Phonebook");

            foreach (Person person in phonebook)
            {
                Console.WriteLine($"Name: {person.Name} Surname: {person.Surname} Phone Number: {person.PhoneNumber}");
            }

        }

        public void Search()
        {
            Console.WriteLine("Choose the type of search:");
            Console.WriteLine("To search by name or surname: 1    To search by phone number: 2");

            string searchType = Console.ReadLine();

            if (searchType == "1")
            {
                Console.WriteLine("Please enter the name or surname to search:");
                string searchTerm = Console.ReadLine();

                var searchResults = phonebook.Where(person => person.Name.Contains(searchTerm) || person.Surname.Contains(searchTerm));

                Search(searchText);
            }
            else if (searchType == "2")
            {
                Console.WriteLine("Please enter the phone number to search:");
                string searchTerm = Console.ReadLine();

                var searchResults = phonebook.Where(person => person.PhoneNumber.Contains(searchTerm));

                Search(searcHText);
            }
            else
            {
                Console.WriteLine("Invalid choice. Ending the process.");
            }
        }

        private static  void DisplaySearchResults(List<Person> search)
        {
            Console.WriteLine("Search Results:");
            foreach (Person person in search)
            {
                Console.WriteLine($"Name: {person.Name} Surname: {person.Surname} Phone Number: {person.PhoneNumber}");
            }
        }
    }

}
