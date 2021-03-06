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
    public partial class GainsAndLossesRow : UserControl
    {
        public GainsAndLossesRow(string type, double change)
        {
            InitializeComponent();
            labelType.Text = type;
            labelChange.Text = change.ToString(App.NUMBER_DISPLAY_FORMAT);

            if (change > 0)
            {
                labelChange.ForeColor = App.inProfit;
            }
            else if (change < 0)
            {
                labelChange.ForeColor = App.inLoss;
            }
        }
    }
}
