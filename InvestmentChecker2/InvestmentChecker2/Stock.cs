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
        public DateTime dateBought;

        private double currentPrice;
        public double CurrentPrice
        {
            get
            {
                string[] res = App.RunScript(App.GET_STOCK_PRICE_SCRIPT_PATH, ticker);
                currentPrice = double.Parse(res[1], CultureInfo.InvariantCulture);
                return currentPrice;
            }
            set { currentPrice = value; }
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
            get { return ((currentPrice / buyingPrice) * 100) - 100; }
            set { }
        }

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

