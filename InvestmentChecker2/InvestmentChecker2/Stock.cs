using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentChecker2
{
    class Stock
    {
        public string ticker;
        public string name;
        public double buyingPrice;
        public int quantity;
        public DateTime dateBought;

        public double marketvalue { 
            get
            {
                return buyingPrice * quantity;
            } 
            set { }
        }


        public Stock(string ticker, string name, double buyingPrice, int quantity, DateTime dateBought)
        {
            this.ticker = ticker;
            this.name = name;
            this.buyingPrice = buyingPrice;
            this.quantity = quantity;
            this.dateBought = dateBought;
        }
    }
}

