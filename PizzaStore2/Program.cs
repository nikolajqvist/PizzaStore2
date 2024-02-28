using System.Dynamic;

namespace PizzaStore2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Costumer cos = new Costumer("", 0);
            Pizza pizza = new Pizza("", 0);
            Order order = new Order(pizza,cos, 0);
            PizzaStore pizzastore = new PizzaStore();

            pizzastore.Start();
            Console.WriteLine();
        }
    }
}
