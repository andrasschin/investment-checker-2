using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    public partial class AddCurrencyExchangeWindow : Form
    {
        public AddCurrencyExchangeWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewCurrencyExchange(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter($"{App.GetCurrencyExchangesFolderPath()}/currency-exchanges.csv", append: true))
            {
                string[] currencyExchangeInformation = { App.NEXT_CURRENCY_EXCHANGE_ID.ToString(), textInputCurrencyFrom.Text, textInputCurrencyTo.Text, textInputQuantity.Text, textInputBuyingPrice.Text, textInputDateBought.Text };
                sw.WriteLine(App.CreateCSVLine(currencyExchangeInformation));
            }
            Close();
        }
    }
}
