using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public interface IVending
    {
        int BuyProduct(int productNumber); //Purchase, to buy a product, get product if able to buy otherwise return null or throw exception.

        string[] GetProducts(); //ShowAll, show all products, get list of string´s with Id/Name/Cost of product.

        string GetDescription(int description); //Details, show detailed information of a selected product, get a string with information about the product

        int InsertMoney(int amount);//InsertMoney, add money to the pool.
        Dictionary<int, int> EndSession(); //EndTransaction, returns money left in appropriate amount of change (Dictionary<int, int>).

    }
}
