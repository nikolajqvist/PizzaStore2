using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class PizzaStore
    {
        private Order _order1;
        private Order _order2;
        private Order _order3;

        internal Order Order1 { get => _order1; set => _order1 = value; }
        internal Order Order2 { get => _order2; set => _order2 = value; }
        internal Order Order3 { get => _order3; set => _order3 = value; }

        public void Start()
        {
            Order order1 = new Order("Miki", 100);
        }
    }
}
