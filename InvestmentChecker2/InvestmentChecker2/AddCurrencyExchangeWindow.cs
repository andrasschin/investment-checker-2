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
    public partial class AddCurrencyExchangeWindow : Form
    {
        public AddCurrencyExchangeWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewCurrencyExchange(object sender, EventArgs e)
        {
            string validationResult = ValidateTextInputs();
            if (validationResult == "")
            {
                using (StreamWriter sw = new StreamWriter($"{App.GetCurrencyExchangesFolderPath()}/currency-exchanges.csv", append: true))
                {
                    string[] currencyExchangeInformation = { 
                        App.NEXT_CURRENCY_EXCHANGE_ID.ToString(), 
                        comboBoxSelectCurrencyFrom.SelectedItem.ToString(), 
                        comboBoxSelectCurrencyTo.SelectedItem.ToString(), 
                        textInputQuantity.Text, 
                        textInputBuyingPrice.Text, 
                        textInputDateBought.Text 
                    };
                    sw.WriteLine(App.CreateCSVLine(currencyExchangeInformation));
                }
                Close();
            }
            else
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

            if (comboBoxSelectCurrencyFrom.SelectedIndex == -1 || comboBoxSelectCurrencyTo.SelectedIndex == -1)
            {
                error += "Please select currencies.";
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
