using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;

namespace VendingMachine.Data
{
public class VendingMachineService:Product,IVending
    {
        public int ProductNumber { get; set; }
        public VendingMachineService(int productNumber,int id, string name, double price, DenominationCurrency denominationCurrency) : base(id, name, price, denominationCurrency)
        {

        }

        public int Amount { get; set; }
       public int MoneyPool { get; set; }

        public int BuyProduct(int productNumber)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, int> EndSession()
        {
            throw new NotImplementedException();
        }

        public override string Examine()
        {
            return $"****Product Information:\n ID:{Id} \n Name: {Name} \n PRICE:{Price} {DenominationCurrency}";
        }

        public string GetDescription(int description)
        {
            return $"You selected item number:{ProductNumber}";
        }

        public string[] GetProducts()
        {
            throw new NotImplementedException();
        }

        public int InsertMoney(int amount)
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
          return "Enjoy your product";
        }
    }
}
