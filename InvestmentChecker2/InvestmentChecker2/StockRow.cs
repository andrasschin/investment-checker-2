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
        public StockRow(string ticker, string name, int quantity, double buyingPrice, DateTime dateBought)
        {
            InitializeComponent();
            labelTicker.Text = ticker;
            labelName.Text = name;
            labelQuantity.Text = quantity.ToString();
            labelBuyingPrice.Text = buyingPrice.ToString();
            labelDateBought.Text = dateBought.ToShortDateString().ToString();
        }
    }
}
