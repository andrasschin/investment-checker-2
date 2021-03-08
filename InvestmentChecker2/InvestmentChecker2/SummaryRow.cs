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
    public partial class SummaryRow : UserControl
    {
        public SummaryRow(string currency, double initialValue, double currentValue)
        {
            InitializeComponent();
            labelCurrency.Text = currency;
            labelInitialCapitalValue.Text = initialValue.ToString(App.NUMBER_DISPLAY_FORMAT);
            labelCurrentCapitalValue.Text = currentValue.ToString(App.NUMBER_DISPLAY_FORMAT);

            double change = currentValue - initialValue;
            labelChange.Text = change.ToString(App.NUMBER_DISPLAY_FORMAT);

            double changePercent = App.GetPercent(initialValue, currentValue);
            labelChangePercent.Text = changePercent.ToString(App.NUMBER_DISPLAY_FORMAT) + "%";

            if (currentValue > initialValue)
            {
                labelChange.ForeColor = App.inProfit;
                labelChangePercent.ForeColor = App.inProfit;
            } else
            {
                labelChange.ForeColor = App.inLoss;
                labelChangePercent.ForeColor = App.inLoss;
            }
        }
    }
}
