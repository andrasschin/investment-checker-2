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
        public SearchStockWindow()
        {
            InitializeComponent();
        }

        private void OpenAddStockWindow(object sender, EventArgs e)
        {
            AddStockWindow window = new AddStockWindow();
            window.Show();
            Close();
        }
    }
}
