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
        int STOCK_ROW_HEIGHT = 65;
        int STOCK_ROW_LEFT_MARGIN = 5;

        // StockRow controls
        List<StockRow> stockRows = new List<StockRow>();
        
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
            // Alternatively I could use 'panelStocks.Controls.Clear();', but I'd need the stockRow list anyways
            foreach (StockRow stockRow in stockRows)
            {
                panelStocks.Controls.Remove(stockRow);
            }
            

            // Display new stocks
            for (int i = 0; i < App.currentStocks.Count; i++)
            {
                Stock s = App.currentStocks[i];
                StockRow stockRow = new StockRow(s.id, s.ticker, s.name, s.quantity, s.buyingPrice, s.dateBought);
                stockRow.Top = i * STOCK_ROW_HEIGHT;
                stockRow.Left = STOCK_ROW_LEFT_MARGIN;

                stockRows.Add(stockRow);
                panelStocks.Controls.Add(stockRow);

                // Set next stock's id
                // There might be a better solution to set this
                App.NEXT_STOCK_ID = s.id;
            }
            App.NEXT_STOCK_ID++;
        }

        private void onProfileChange(object sender, EventArgs e)
        {
            if (App.currentProfile != null && App.stocksToBeDeleted)
            {
                App.UpdateStocksCSV();
            }

            App.currentProfile = comboBoxSelectProfile.SelectedValue.ToString();
            App.ReadStocksFromProfile();
            DisplayCurrentStocks();
        }

        // Open new windows
        private void OpenAddProfileWindow(object sender, EventArgs e)
        {
            AddProfileWindow window = new AddProfileWindow();
            window.Show();
        }

        private void OpenSearchStockWindow(object sender, EventArgs e)
        {
            SearchStockWindow window = new SearchStockWindow();
            window.Show();
        }

        private void OpenSettingsWindow(object sender, EventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
        }

        // Occurs when the form is being closed
        private void MainWindowClose(object sender, FormClosingEventArgs e)
        {
            if (App.stocksToBeDeleted)
            {
                App.UpdateStocksCSV();
            }
        }
    }
}
