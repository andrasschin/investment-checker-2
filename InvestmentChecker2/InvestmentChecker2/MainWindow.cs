using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InvestmentChecker2
{
    public partial class MainWindow : Form
    {
        // Constants
        int STOCK_ROW_HEIGHT = 45;
        int STOCK_ROW_LEFT_MARGIN = 5;

        // StockRow controls
        List<StockRow> stockRows = new List<StockRow>();

        // Python
        string pyfile = "./scripts/script.py";
        string pyexe = @"C:\Users\Andrew\AppData\Local\Programs\Python\Python38-32\python.exe";
        
        public MainWindow()
        {
            InitializeComponent();
            App.LoadProfileNames();
            comboBoxSelectProfile.DataSource = App.profileNames;
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            DisplayCurrentStocks();
        }
        private void DisplayCurrentStocks()
        {
            // Clear out previously displayed stocks
            foreach (StockRow stockRow in stockRows)
            {
                panelStocks.Controls.Remove(stockRow);
            }

            // Display new stocks
            for (int i = 0; i < App.currentStocks.Count; i++)
            {
                Stock s = App.currentStocks[i];
                StockRow stockRow = new StockRow(s.ticker, s.name, s.quantity, s.buyingPrice, s.dateBought);
                stockRow.Top = i * STOCK_ROW_HEIGHT;
                stockRow.Left = STOCK_ROW_LEFT_MARGIN;

                stockRows.Add(stockRow);
                panelStocks.Controls.Add(stockRow);
            }
        }
        private void onProfileChange(object sender, EventArgs e)
        {
            string currentProfile = comboBoxSelectProfile.SelectedValue.ToString();
            App.ReadStocksFromProfile(currentProfile);
            DisplayCurrentStocks();
        }

        // Open new windows
        private void OpenAddProfileWindow(object sender, EventArgs e)
        {
            AddProfileWindow window = new AddProfileWindow();
            window.Show();
        }

        private void openSearchStockWindow(object sender, EventArgs e)
        {
            SearchStockWindow window = new SearchStockWindow();
            window.Show();
        }

        private void OpenSettingsWindow(object sender, EventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
        }
    }
}
