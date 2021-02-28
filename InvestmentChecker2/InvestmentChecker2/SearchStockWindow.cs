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
    public partial class SearchStockWindow : Form
    {
        bool stockExists = false;
        
        private string foundTicker;

        public string FoundTicker
        {
            get { return foundTicker; }
            set {
                foundTicker = value;
                labelFoundTicker.Text = value;
            }
        }

        private string foundName;

        public string FoundName
        {
            get { return foundName; }
            set { 
                foundName = value;
                labelFoundName.Text = value;
            }
        }

        private string foundCurrentPrice;

        public string FoundCurrentPrice
        {
            get { return foundCurrentPrice; }
            set { 
                foundCurrentPrice = value;
                labelFoundCurrentPrice.Text = value;
            }
        }

        private string foundCurrency;

        public string FoundCurrency
        {
            get { return foundCurrency; }
            set { 
                foundCurrency = value;
                labelFoundCurrency.Text = value;
            }
        }


        public SearchStockWindow()
        {
            InitializeComponent();
            btnOpenAddStockWindow.ForeColor = Color.FromArgb(255, 140, 140, 140);
        }

        private void OpenAddStockWindow(object sender, EventArgs e)
        {
            if (stockExists)
            {
                AddStockWindow window = new AddStockWindow(FoundTicker, FoundName, FoundCurrency);
                window.Show();
                Close();
            } else
            {
                App.ShowError("Please search for a valid stock.");
            }
        }

        private void SearchStock(object sender, EventArgs e)
        {
            string ticker = textInputTicker.Text;
            string[] result = App.RunScript(App.GET_STOCK_INFO_SCRIPT_PATH, ticker);

            // Check if we have a valid stock
            if (result[0] == "True")
            {
                stockExists = true;
                btnOpenAddStockWindow.ForeColor = Color.FromArgb(255, 232, 232, 232);
            } else
            {
                stockExists = false;
                btnOpenAddStockWindow.ForeColor = Color.FromArgb(255, 160, 160, 160);
            }

            // Save and display the returned information
            string[] stockInformation = result[1].Split(App.PYTHON_OUTPUT_DELIMITER);
            FoundTicker = stockInformation[0];
            FoundName = stockInformation[1];
            FoundCurrentPrice = stockInformation[2];
            FoundCurrency = stockInformation[3];
        }
    }
}
