using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class Costumer
    {
        private string _name;
        private int _age;
        private string _adress;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Adress { get => _adress; private set => _adress = value; }
        public Costumer(string name, int age)
        {
            _adress = Adress;
            _name = name;
            _age = age;
        }
        public override string ToString()
        {
            return $"{Name} har bestilt en ";
        }
    }
}
