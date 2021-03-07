using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    public partial class ProfileSummaryWindow : Form
    {
        List<Stock> stocks;
        List<CurrencyExchange> currencyExchanges;

        Dictionary<string, double> currenciesBuyingPrice = new Dictionary<string, double>();
        Dictionary<string, double> currenciesCurrentPrice = new Dictionary<string, double>();

        double initialProfileValue = 0;
        double currentProfileValue = 0;
        public ProfileSummaryWindow(List<Stock> stocks, List<CurrencyExchange> currencyExchanges)
        {
            InitializeComponent();
            this.stocks = stocks;
            this.currencyExchanges = currencyExchanges;
            labelChange.Text = $"Change (in {App.currentProfileMainCurrency})";

            GetCurrencyPrices();
            DisplaySummaryRows();

            // Overall
            DisplayOverall();
        }

        void GetCurrencyPrices()
        {
            currenciesBuyingPrice.Add(App.currentProfileMainCurrency, 1);
            currenciesCurrentPrice.Add(App.currentProfileMainCurrency, 1);

            // Get current price for currencies present in portfolio
            string[] uniqueCurrencies = currencyExchanges.Select(x => x.currencyTo).Distinct().ToArray();

            for (int i = 0; i < uniqueCurrencies.Length; i++)
            {
                string currency = uniqueCurrencies[i];

                // Current price
                try
                {
                    string ticker = $"{currency}{App.currentProfileMainCurrency}=X";

                    double currentPrice = double.Parse(App.RunScript(App.GET_STOCK_PRICE_SCRIPT_PATH, ticker), CultureInfo.InvariantCulture);
                    currenciesCurrentPrice.Add(currency, currentPrice);
                }
                catch (Exception)
                {
                    continue;
                }

                // Buying price
                List<CurrencyExchange> ce = currencyExchanges.FindAll(x => x.currencyTo == currency).ToList();
                double sumOfQuantities = ce.Sum(x => x.quantity);
                double sumOfBuyingMarketValues = ce.Sum(x => x.BuyingMarketValue);
                double averageBuyingPrice = sumOfBuyingMarketValues / sumOfQuantities;
                currenciesBuyingPrice.Add(currency, averageBuyingPrice);
            }
        }
        void DisplaySummaryRows()
        {
            foreach (KeyValuePair<string, double> currency in currenciesBuyingPrice)
            {
                string currencyName = currency.Key;
                double currencyBuyingPrice = currency.Value;
                double currencyCurrentPrice = currenciesCurrentPrice[currencyName];

                double initialCapitalValue = stocks.Where(x => x.currency == currencyName).Sum(x => x.BuyingMarketValue);
                double currentCapitalValue = stocks.Where(x => x.currency == currencyName).Sum(x => x.CurrentMarketValue);
                double change = currentCapitalValue - initialCapitalValue;
                
                if (initialCapitalValue != 0)
                {
                    SummaryRow sr = new SummaryRow(currencyName, initialCapitalValue, currentCapitalValue);
                    sr.Top = panelStockSummaries.Controls.Count * 65;
                    panelStockSummaries.Controls.Add(sr);

                    // Gain/loss from stock
                
                    double gainFromStocksInMainCurr = change * currencyBuyingPrice;

                    GainsAndLossesRow galrs = new GainsAndLossesRow(currencyName, gainFromStocksInMainCurr);
                    galrs.Top = panelGainsAndLosses.Controls.Count * 65;
                    panelGainsAndLosses.Controls.Add(galrs);
                }

                // Gain/loss from currency
                if (currencyName != App.currentProfileMainCurrency)
                {
                    double gainFromCurrInMainCurr = currentCapitalValue * (currencyCurrentPrice - currencyBuyingPrice);
                    GainsAndLossesRow galrc = new GainsAndLossesRow($"{currencyName}{App.currentProfileMainCurrency}", gainFromCurrInMainCurr);
                    galrc.Top = panelGainsAndLosses.Controls.Count * 65;
                    panelGainsAndLosses.Controls.Add(galrc);
                }

                // Overall
                initialProfileValue += initialCapitalValue * currencyBuyingPrice;
                currentProfileValue += currentCapitalValue * currencyCurrentPrice;
            }
        }
        void DisplayOverall()
        {
            SummaryRow sro = new SummaryRow(App.currentProfileMainCurrency, initialProfileValue, currentProfileValue);
            panelOverall.Controls.Add(sro);
        }
    }
}
