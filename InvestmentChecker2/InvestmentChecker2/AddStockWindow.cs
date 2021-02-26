using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    public partial class AddStockWindow : Form
    {
        string ticker;
        string profileToAddTo;
        public AddStockWindow(string ticker, string defaultName)
        {
            InitializeComponent();
            this.ticker = ticker;
            profileToAddTo = App.currentProfile;

            labelFoundTicker.Text = ticker;
            textInputName.Text = defaultName;
            btnAddStock.Text = $"Add stock to: {profileToAddTo}";
        }

        private void AddStock(object sender, EventArgs e)
        {
            string validationResult = ValidateTextInputs();
            if (validationResult == "")
            {
                // Save the stock
                using (StreamWriter sw = new StreamWriter($"{App.GetStocksFolderPathForProfile(profileToAddTo)}/stocks.csv", append: true))
                {
                    string[] stockInformation = { App.NEXT_STOCK_ID.ToString(), ticker, textInputName.Text, textInputQuantity.Text, textInputBuyingPrice.Text, textInputDateBought.Text };
                    sw.WriteLine(App.CreateCSVLine(stockInformation));
                }
                App.NEXT_STOCK_ID++;
                Close();
            } else
            {
                App.ShowError(validationResult);
            }
        }

        string ValidateTextInputs()
        {
            string error = "";
            
            double tempD;
            int tempI;
            DateTime tempDT;

            if (textInputName.TextLength == 0)
            {
                error += "Name can't be empty.\n";
            }

            if ((textInputBuyingPrice.TextLength) == 0 || !(double.TryParse(textInputBuyingPrice.Text, out tempD)))
            {
                error += "Buying price must be a number (decimals seperated with a comma).\n";
            }
            if ((textInputQuantity.TextLength == 0) || !(int.TryParse(textInputQuantity.Text, out tempI)))
            {
                error += "Quantity has to be a whole number.\n";
            }
            if ((textInputDateBought.TextLength == 0) || !(DateTime.TryParse(textInputDateBought.Text, out tempDT)))
            {
                error += "Date bought field has to be in valid date format. (E.g. YYYY.MM.DD)\n";
            }

            return error;

        }
    }
}
