using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    public partial class StockRow : UserControl
    {
        int fracDigits;
        Stock stock;

        private double priceDifference;

        public double PriceDifference
        {
            get { return priceDifference; }
            set { priceDifference = value; }
        }

        private double currentPrice;

        public double CurrentPrice
        {
            get { return currentPrice; }
            set { 
                currentPrice = value;
                labelCurrentPrice.Text = Math.Round(currentPrice, fracDigits).ToString(App.NUMBER_DISPLAY_FORMAT);
                labelPriceDifference.Text = Math.Round(stock.PriceDifference, fracDigits).ToString(App.NUMBER_DISPLAY_FORMAT);
                labelBuyingMarketValue.Text = stock.BuyingMarketValue.ToString(App.NUMBER_DISPLAY_FORMAT);
                labelCurrentMarketValue.Text = Math.Round(stock.CurrentMarketValue, fracDigits).ToString(App.NUMBER_DISPLAY_FORMAT);
                labelMarketValueDifference.Text = Math.Round(stock.MarketValueDifference, fracDigits).ToString(App.NUMBER_DISPLAY_FORMAT);
                labelChangePercent.Text = Math.Round(stock.ChangePercent, fracDigits).ToString() + "%";

                if (stock.PriceDifference > 0)
                {
                    labelPriceDifference.ForeColor = App.inProfit;
                    labelMarketValueDifference.ForeColor = App.inProfit;
                    labelChangePercent.ForeColor = App.inProfit;
                }
                else if (stock.PriceDifference < 0)
                {
                    labelPriceDifference.ForeColor = App.inLoss;
                    labelMarketValueDifference.ForeColor = App.inLoss;
                    labelChangePercent.ForeColor = App.inLoss;
                }
            }
        }


        public StockRow(Stock stock)
        {
            InitializeComponent();
            this.stock = stock;
            fracDigits = App.NUMBER_OF_FRAC_DIGITS;

            labelTicker.Text = stock.ticker;
            labelName.Text = stock.name;
            labelQuantity.Text = stock.quantity.ToString(App.NUMBER_DISPLAY_FORMAT);
            labelBuyingPrice.Text = stock.buyingPrice.ToString(App.NUMBER_DISPLAY_FORMAT);
            labelCurrency.Text = stock.currency;
            labelDateBought.Text = stock.dateBought.ToShortDateString().ToString();
        }
        private void RemoveStock(object sender, EventArgs e)
        {
            // Delete from the stock's list
            // Find the index based on the stock's id
            int foundIndex = 0;
            while (stock.id != App.currentStocks[foundIndex].id)
            {
                foundIndex++;
            }
            App.currentStocks.RemoveAt(foundIndex);

            // Remove the control
            Parent.Controls.Remove(this);

            // Schedule for deletion in stocks.csv
            App.stocksToBeDeleted = true;

        }
    }
}
