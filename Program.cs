using VendingMachine.Models;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
           Drink drink = new Drink(1,"Cola",20,DenominationCurrency.KR);
            //drink.Name = "Cola";
            //drink.Price = 20;
            //drink.DenominationCurrency= DenominationCurrency.KR;

            Console.WriteLine(drink.Examine());
            Console.WriteLine("How to use the product:"+" "+drink.Use());
        }
    }
}