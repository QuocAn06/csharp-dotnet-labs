using System;
using System.Collections.Generic;
using System.IO;
using ContactManagerLab.Models;
using ContactManagerLab.Utils;

namespace ContactManagerLab.Services
{
    public class ContactService
    {
        private static readonly string filePath = Path.Combine(
            Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName, "Data", "contacts.csv");

        // 1. Thêm liên hệ mới và ghi vào file CSV
        public void AddContact()
        {
            Console.WriteLine("\n--- Add New Contact ---");

            string name = InputHelper.GetName();
            string phone = InputHelper.GetPhoneNumber();
            string email = InputHelper.GetEmail();

            var contact = new Contact(name, phone, email);

            try
            {
                Directory.CreateDirectory("Data"); // Bảo đảm thư mục tồn tại

                Console.WriteLine($"[DEBUG] Writing to file: {Path.GetFullPath(filePath)}");

                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine($"{contact.Name},{contact.PhoneNumber},{contact.Email}");
                }

                Console.WriteLine("Contact saved successfully.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Saving contact: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        // 2. Đọc danh bạ từ file CSV và in ra màn hình
        public void ViewContacts()
        {
            Console.WriteLine("\n--- Contact List ---");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("No contacts found.\n");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);

                Console.WriteLine($"[DEBUG] Writing to file: {Path.GetFullPath(filePath)}");

                if (lines.Length == 0)
                {
                    Console.WriteLine("Contact list is empty.\n");
                    return;
                }

                foreach (var line in lines)
                {
                    var parts = line.Split(",");

                    if (parts.Length == 3)
                    {
                        string fullName = parts[0];
                        string phoneNumber = parts[1];
                        string email = parts[2];

                        var contact = new Contact(fullName, phoneNumber, email);
                        Console.WriteLine(contact.ToString());
                    }
                }

                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Reading contacts: {ex.Message}");

            }

        }

    }
}
