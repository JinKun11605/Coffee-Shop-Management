using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShopManagement
{
    public class Manager : EmployeeInfo
    {
        public Manager() { }
        public Manager(string id, string password, string fullName, DateTime birthDay, string phoneNumber,
            string role, DateTime hireDay, int yoE, decimal salary, byte[] image)
            : base(id, password, fullName, birthDay, phoneNumber, "Manager", hireDay, yoE, salary, image) { }
    }
}