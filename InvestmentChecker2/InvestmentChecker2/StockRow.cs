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
        int id;
        public StockRow(int id, string ticker, string name, int quantity, double buyingPrice, DateTime dateBought)
        {
            InitializeComponent();
            labelTicker.Text = ticker;
            labelName.Text = name;
            labelQuantity.Text = quantity.ToString();
            labelBuyingPrice.Text = buyingPrice.ToString();
            labelDateBought.Text = dateBought.ToShortDateString().ToString();

            this.id = id;
        }

        private void RemoveStock(object sender, EventArgs e)
        {
            // Delete from the stock's list
            // Find the index based on the stock's id
            int foundIndex = 0;
            while (id != App.currentStocks[foundIndex].id)
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
