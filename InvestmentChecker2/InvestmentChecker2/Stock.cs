using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentChecker2
{
    class Stock
    {
        public int id;
        public string ticker;
        public string name;
        public double buyingPrice;
        public int quantity;
        public DateTime dateBought;

        public Stock(int id, string ticker, string name, double buyingPrice, int quantity, DateTime dateBought)
        {
            this.id = id;
            this.ticker = ticker;
            this.name = name;
            this.buyingPrice = buyingPrice;
            this.quantity = quantity;
            this.dateBought = dateBought;
        }

        public string[] GetOutputArray()
        {
            string[] output = { id.ToString(), ticker, name, buyingPrice.ToString(), quantity.ToString(), dateBought.ToShortDateString().ToString() };
            return output;
        }
    }
}

