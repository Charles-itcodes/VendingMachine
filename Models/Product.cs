using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DenominationCurrency DenominationCurrency { get; set; }
        public Product(int id, string name, double price, DenominationCurrency denominationCurrency)
        {
            Id = id;
            Name = name;
            Price = price;
            DenominationCurrency = denominationCurrency;
        }

        public abstract string Examine();
        public abstract string Use();
        
    }
}
