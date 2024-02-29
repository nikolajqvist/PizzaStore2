using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class Order
    {
        private Pizza _pizzaname;
        private Costumer _name;
        private Pizza _price;
        private int _morePizza;
        private int _totalPrice;
        private int _orderId;
        private int _orderNumber;
        private static int _idcounter = 0;
        private DateTime _date;
        private int _numberOfPizza;


        public Pizza Pizzaname { get => _pizzaname; set => _pizzaname = value; }
        public Costumer Name { get => _name; set => _name = value; }
        public Pizza Price { get => _price; set => _price = value; } 
        public int TotalPrice { get { return _totalPrice; } }
        public DateTime Date { get { return _date; } }
        public int NumberOfPizza { get{ return _numberOfPizza; } }

        public int OrderId { get => _orderId; private set => _orderId = value; }
        public int OrderNumber { get { return _orderNumber; } }

        public int MorePizza { get => _morePizza; set => _morePizza = value; }

        public Order(Pizza Pizzaname, Costumer Name, int NumberOfPizza) 
        {
            _orderId = _idcounter;
            _idcounter++;
            _pizzaname = Pizzaname;
            _name = Name;
            _totalPrice = TotalPrice;
            _date = DateTime.Now;
            _price = Price;
            _numberOfPizza = NumberOfPizza;

        }
        public void CalculateTotalPrice()
        {
            _totalPrice = Pizzaname.Price * NumberOfPizza + 40;
        }
        public override string ToString()
        {
            return $"Ordernr:{OrderId} Tid:{Date}. {Pizzaname} kr." +
                $" + 40 kr. in shipping and the total price is {TotalPrice} kr. and there is {NumberOfPizza} pizzas. For {Name}!";
        }
    }
}
