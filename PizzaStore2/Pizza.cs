using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class Pizza
    {
        private string _pizza;
        private int _pizzaprice;
        public string Pizzaname { get => _pizza; set => _pizza = value; }
        public int PizzaPrice { get => _pizzaprice; set => _pizzaprice = value; }
        public Pizza(string pizza, int pizzaprice)
        {
            _pizza = pizza;
            _pizzaprice = pizzaprice;
        }
        public override string ToString()
        {
            return $"{Pizzaname} som koster {PizzaPrice}kr med ekstra ";
        }
    }
}
