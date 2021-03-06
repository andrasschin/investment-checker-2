using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentChecker2
{
    public class CurrencyExchange
    {
        public int id;
        public string currencyFrom;
        public string currencyTo;
        public int quantity;
        public double buyingPrice;
        public DateTime dateBought;
        public double BuyingMarketValue
        {
            get {
                return quantity * buyingPrice;
            }
            set {  }
        }

        public CurrencyExchange(int id, string currencyFrom, string currencyTo, int quantity, double buyingPrice, DateTime dateBought)
        {
            this.id = id;
            this.currencyFrom = currencyFrom;
            this.currencyTo = currencyTo;
            this.quantity = quantity;
            this.buyingPrice = buyingPrice;
            this.dateBought = dateBought;
        }

        public string[] GetOutputArray()
        {
            string[] output = { id.ToString(), currencyFrom, currencyTo, quantity.ToString(), buyingPrice.ToString(), dateBought.ToString() };
            return output;
        }
    }
}
