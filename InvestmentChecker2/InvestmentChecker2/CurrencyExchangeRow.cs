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
        public CurrencyExchangeRow(CurrencyExchange ce)
        {
            InitializeComponent();
            labelCurrencyFrom.Text = ce.currencyFrom;
            labelCurrencyTo.Text = ce.currencyTo;
            labelQuantity.Text = ce.quantity.ToString();
            labelBuyingPrice.Text = ce.buyingPrice.ToString();
            labelBuyingMarketValue.Text = ce.BuyingMarketValue.ToString();
            labelDateBought.Text = ce.dateBought.ToShortDateString();
        }
    }
}
