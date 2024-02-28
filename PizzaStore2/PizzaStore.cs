using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class PizzaStore
    {


        public void Start()
        {
            Pizza pizza1 = new Pizza("Margarita", 100);
            Pizza pizza2 = new Pizza("Pepperoni", 100);
            Pizza pizza3 = new Pizza("Meatzza", 100);
            Costumer cos1 = new Costumer("Mogens", 56);
            Costumer cos2 = new Costumer("Vibeke", 51);
            Costumer cos3 = new Costumer("Camilla", 41);
            //Når man kalder en costruktor med objekter i skal den ikke oprettes, men i en metode.
            Order order1 = new Order(pizza1, cos1, 3);
            Order order2 = new Order(pizza2, cos2, 2);
            Order order3 = new Order(pizza3, cos3, 4);
            order1.CalculateTotalPrice();
            order2.CalculateTotalPrice();
            order3.CalculateTotalPrice();
            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
            Console.ReadKey();
            
        }
    }
}
