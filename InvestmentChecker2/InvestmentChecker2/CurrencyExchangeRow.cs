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
    public partial class CurrencyExchangeRow : UserControl
    {
        int id;
        public CurrencyExchangeRow(CurrencyExchange ce)
        {
            InitializeComponent();
            id = ce.id;

            labelCurrencyFrom.Text = ce.currencyFrom;
            labelCurrencyTo.Text = ce.currencyTo;
            labelQuantity.Text = ce.quantity.ToString(App.NUMBER_DISPLAY_FORMAT);
            labelBuyingPrice.Text = ce.buyingPrice.ToString(App.NUMBER_DISPLAY_FORMAT);
            labelBuyingMarketValue.Text = ce.BuyingMarketValue.ToString(App.NUMBER_DISPLAY_FORMAT);
            labelDateBought.Text = ce.dateBought.ToShortDateString();
        }

        private void RemoveCurrencyExchange(object sender, EventArgs e)
        {
            // Delete from the stock's list
            // Find the index based on the stock's id
            int foundIndex = 0;
            while (id != App.currentCurrencyExchanges[foundIndex].id)
            {
                foundIndex++;
            }
            App.currentCurrencyExchanges.RemoveAt(foundIndex);

            // Remove the control
            Parent.Controls.Remove(this);

            // Schedule for deletion in stocks.csv
            App.currencyExchangeToBeDeleted = true;
        }
    }
}
