using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShopManagement
{
    public class Barista : EmployeeInfo
    {
        public Barista() { }
        public Barista(string id, string password, string fullName, DateTime birthDay, string phoneNumber,
            DateTime hireDay, int yoE, decimal salary, byte[] image)
            : base(id, password, fullName, birthDay, phoneNumber, "Barista", hireDay, yoE, salary, image) { }
    }
}