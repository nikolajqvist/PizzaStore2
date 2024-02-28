using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Pizza
    {
        private string _pizzaName;
        private int _price;

        public string PizzaName { get { return _pizzaName; } }
        public int Price { get { return _price; } }

        public Pizza(string PizzaName, int Price)
        {
            _pizzaName = PizzaName;
            _price = Price;
        }

        public override string ToString()
        {
            return $"{PizzaName} cost {Price}";
        }
    }
}
