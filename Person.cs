using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public abstract class Person
    {
        private string id;         
        private string password;       
        private string fullName;         
        private DateTime birthDay;      
        private string phoneNumber;     

        public string ID { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Person() { }
        public Person(string id, string password, string fullName, DateTime birthDay, string phoneNumber)
        {
            ID = id;
            Password = password;
            FullName = fullName;
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;
        }

        public virtual string PrintDetails()
        {
            return $"Họ và tên: {FullName} \nID: {ID} \nSĐT: {PhoneNumber} \nNgày sinh: {BirthDay} \n";
        }
    }
}
