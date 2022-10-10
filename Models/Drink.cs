using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Drink : Product
    {
        public Drink(int id, string name, double price, DenominationCurrency denominationCurrency) : base(id, name, price, denominationCurrency)
        {

        }

        public override string Examine()
        {
            return $"****Product Information:\n ID:{Id} \n Name: {Name} \n PRICE:{Price} {DenominationCurrency}";
        }

        public override string Use()
        {
          return "Cheers! Enjoy your drink";
        }
    }
}
