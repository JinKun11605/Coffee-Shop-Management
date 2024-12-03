using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement
{
    public class Recipe
    {
        private string productID;
        private Dictionary<string, int> ingredients;
 
        public string ProductID { get => productID; set => productID = value; }
        public Dictionary<string, int> Igredients { get => ingredients; set => ingredients = value; }

        public Recipe(string productID, Dictionary<string, int> ingredients)
        {
            this.productID = productID;
            this.ingredients = ingredients;
        }
    }
}
