using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class Order
    {
        private int _orderNumber;
        private int _id;
        private static int idcounter = 0;
        private DateTime _date;
        private Pizza _pizza;

        public int OrderNumber { get => _orderNumber; private set => _orderNumber = value; }
        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        internal Pizza Pizza { get => _pizza; set => _pizza = value; }

        public Order(string pizzaname, int price)
        {
            Id = idcounter;
            idcounter++;
            Date = DateTime.Now;
            _pizza = new Pizza("", 0);
        }
        public override string ToString()
        {
            return "Ordrenr:" + Id + " er kommet " + Date.ToString("kl: HH:mm: ss");
        }
        public void Start()
        {

        }
    }
}
