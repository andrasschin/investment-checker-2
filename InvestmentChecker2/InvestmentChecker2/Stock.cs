using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentChecker2
{
    public class Stock
    {
        public int id;
        public string ticker;
        public string name;
        public double buyingPrice;
        public int quantity;
        public string currency;
        public DateTime dateBought;

        private double currentPrice;
        public double CurrentPrice
        {
            get
            { return currentPrice; }
            set { 
                currentPrice = value;
                stockRow.CurrentPrice = value;
            }
        }
        public double BuyingMarketValue
        {
            get { 
                return buyingPrice * quantity; 
            }
            set { }
        }
        public double CurrentMarketValue
        {
            get { 
                return currentPrice * quantity; 
            }
            set {  }
        }
        public double PriceDifference
        {
            get { 
                return currentPrice - buyingPrice; 
            }
            set {  }
        }
        public double MarketValueDifference
        {
            get { 
                return CurrentMarketValue - BuyingMarketValue; 
            }
            set { }
        }
        public double ChangePercent
        {
            get { return App.GetPercent(buyingPrice, currentPrice); }
            set { }
        }

        public StockRow stockRow;

        public Stock(int id, string ticker, string name, double buyingPrice, int quantity, string currency, DateTime dateBought)
        {
            this.id = id;
            this.ticker = ticker;
            this.name = name;
            this.buyingPrice = buyingPrice;
            this.quantity = quantity;
            this.currency = currency;
            this.dateBought = dateBought;
        }

        public string[] GetOutputArray()
        {
            string[] output = { 
                id.ToString(), 
                ticker, 
                name, 
                quantity.ToString(), 
                buyingPrice.ToString(),
                currency,
                dateBought.ToShortDateString().ToString() 
            };
            return output;
        }
    }
}

