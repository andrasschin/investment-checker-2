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
        Color oddRow = Color.FromArgb(255, 24, 24, 24);
        Color evenRow = Color.FromArgb(255, 32, 32, 32);

        // StockRow controls
        List<StockRow> stockRows = new List<StockRow>();
        List<CurrencyExchangeRow> currencyExchangeRows = new List<CurrencyExchangeRow>();
        
        public MainWindow()
        {
            InitializeComponent();
            App.LoadProfileNames();
            comboBoxSelectProfile.DataSource = App.profileNames;
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            
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
                Stock stock = App.currentStocks[i];
                StockRow stockRow = new StockRow(stock);
                stock.stockRow = stockRow;

                stockRow.Top = i * STOCK_ROW_HEIGHT;
                stockRow.Left = STOCK_ROW_LEFT_MARGIN;
                stockRow.BackColor = i % 2 == 0 ? evenRow : oddRow;

                stockRows.Add(stockRow);
                panelStocks.Controls.Add(stockRow);

                // Set next stock's id
                // There might be a better solution to set this
                App.NEXT_STOCK_ID = stock.id;
            }
            App.NEXT_STOCK_ID++;
        }
        private void DisplayCurrentCurrencyExchanges()
        {
            foreach (CurrencyExchangeRow currencyExchangeRow in currencyExchangeRows)
            {
                panelCurrencyExhanges.Controls.Remove(currencyExchangeRow);
            }

            for (int i = 0; i < App.currentCurrencyExchanges.Count; i++)
            {
                CurrencyExchange ce = App.currentCurrencyExchanges[i];
                CurrencyExchangeRow cer = new CurrencyExchangeRow(ce);
                cer.Top = i * STOCK_ROW_HEIGHT;
                cer.BackColor = i % 2 == 0 ? evenRow : oddRow;

                currencyExchangeRows.Add(cer);
                panelCurrencyExhanges.Controls.Add(cer);

                App.NEXT_CURRENCY_EXCHANGE_ID = ce.id;
            }
            App.NEXT_CURRENCY_EXCHANGE_ID++;
        }

        private void onProfileChange(object sender, EventArgs e)
        {
            if (App.currentProfile != null && App.stocksToBeDeleted)
            {
                App.UpdateStocksCSV();
            }

            if (App.currentProfile != null && App.currencyExchangeToBeDeleted)
            {
                App.UpdateCurrencyExchangesCSV();
            }

            App.currentProfile = comboBoxSelectProfile.SelectedValue.ToString();
            App.ReadStocksForProfile();
            App.ReadCurrencyExchangesForProfile();
            DisplayCurrentStocks();
            DisplayCurrentCurrencyExchanges();
            App.GetCurrentPricesForCurrentStocks();
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

            if (App.currencyExchangeToBeDeleted)
            {
                App.UpdateCurrencyExchangesCSV();
            }
        }

        private void OpenAddCurrencyExchangeWindow(object sender, EventArgs e)
        {
            AddCurrencyExchangeWindow window = new AddCurrencyExchangeWindow();
            window.Show();
        }

        private void OpenProfileSummaryWindow(object sender, EventArgs e)
        {
            ProfileSummaryWindow window = new ProfileSummaryWindow(App.currentStocks, App.currentCurrencyExchanges);
            window.Show();
        }
    }
}
