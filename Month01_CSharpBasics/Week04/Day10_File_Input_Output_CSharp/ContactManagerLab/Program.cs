
using ContactManagerLab.Services;

namespace ContactManagerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactService = new ContactService();

            while (true)
            {
                Console.WriteLine("=== Contact Manager ===");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        contactService.AddContact();
                        break;

                    case "2":
                        contactService.ViewContacts();
                        break;

                    case "0":
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select 0, 1 or 2.\n");
                        break;

                }
            }
        }
    }
}