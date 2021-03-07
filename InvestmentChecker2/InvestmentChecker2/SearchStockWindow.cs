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
        
        private string searchedTicker;
        public string SearchedTicker
        {
            get { return searchedTicker; }
            set {
                searchedTicker = value;
                labelSearchedTicker.Text = value;
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
                AddStockWindow window = new AddStockWindow(SearchedTicker, FoundName, FoundCurrency);
                window.Show();
                Close();
            } else
            {
                App.ShowError("Please search for a valid stock.");
            }
        }

        private void SearchStock(object sender, EventArgs e)
        {
            string ticker = textInputTicker.Text.ToUpper();
            string[] result = App.RunScript(App.GET_STOCK_INFO_SCRIPT_PATH, ticker).Split(';');

            // Check if we have a valid stock
            if (result[2] == "-1")
            {
                stockExists = false;
                SearchedTicker = result[0];
                FoundName = "Not found";
                FoundCurrentPrice = "Not found";
                FoundCurrency = "Not found";
                btnOpenAddStockWindow.ForeColor = Color.FromArgb(255, 160, 160, 160);
            } else
            {
                stockExists = true;
                SearchedTicker = result[0];
                FoundName = result[1];
                FoundCurrentPrice = result[2];
                FoundCurrency = result[3];
                btnOpenAddStockWindow.ForeColor = Color.FromArgb(255, 232, 232, 232);
            }
        }
    }
}
