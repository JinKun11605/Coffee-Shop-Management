using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class EmployeeInfo : Person
    {
        private string role;
        private DateTime hireDay;
        private int yoE;
        private decimal salary;
        private byte[] image;

        public string Role { get => role; set => role = value; }
        public DateTime HireDay { get => hireDay; set => hireDay = value; }
        public int YoE { get => yoE; set => yoE = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public byte[] Image { get => image; set => image = value; }

        public EmployeeInfo() { }

        public EmployeeInfo(string id, string password, string fullName, DateTime birthDay, string phoneNumber,
            string role, DateTime hireDay, int yoE, decimal salary, byte[] image) 
            : base(id, password, fullName, birthDay, phoneNumber)
        {
            Role = role;
            HireDay = hireDay;
            YoE = yoE;
            Salary = salary;
            Image = image;
        }
    }
}
