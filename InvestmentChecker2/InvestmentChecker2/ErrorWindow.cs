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
    public partial class ErrorWindow : Form
    {
        public ErrorWindow(string errorMsg)
        {
            InitializeComponent();
            labelErrorMessage.Text = errorMsg;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
