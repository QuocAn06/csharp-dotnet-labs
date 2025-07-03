using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagerLab.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // 1. Khởi tạo object rỗng
        public Contact() { }

        // 2. Khởi tạo object từ dữ liệu đã có
        public Contact(string name, string phoneNumber, string email)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        // 3. In thông tin ra màn hình
        public override string ToString()
        {
            var contactInfo = $"Name: {Name}, Phone: {PhoneNumber}, Email: {Email}";

            return contactInfo;
        }

    }
}
