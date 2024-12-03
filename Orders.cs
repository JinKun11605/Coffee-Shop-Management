using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Orders
    {
        private int customeID;
        private DateTime orderDate;
        private int rating;
        private decimal total;

        
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public int Rating { get => rating; set => rating = value; }
        public decimal Total { get => total; set => total = value; }
        public int CustomeID { get => customeID; set => customeID = value; }
    }
}
