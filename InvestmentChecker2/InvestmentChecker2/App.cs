using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    class App
    {
        // GLOBAL CONSTANTS
        
        // Folder paths
        public static string PROFILES_FOLDER_PATH = "./profiles/";
        public static string getStocksFolderPath(string profileName)
        {
            return $"./profiles/{profileName}/stocks";
        }

        // Files
        public static char CSV_DELIMITER = ';';


        // GLOBAL VARIABLES

        // Profiles
        public static BindingList<string> profileNames = new BindingList<string>();

        // Stocks
        public static List<Stock> currentStocks = new List<Stock>();

        // FUNCTIONS

        // Get profiles from 'stocks' folder, otherwise create the 'profiles' folder
        public static void LoadProfileNames()
        {
            profileNames.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo(PROFILES_FOLDER_PATH);
                var res = di.EnumerateDirectories("*").ToArray();
                for (int i = 0; i < res.Length; i++)
                {
                    profileNames.Add(res[i].Name);
                }

            }
            catch (Exception)
            {
                Directory.CreateDirectory("./profiles");
            }
        }

        // Read stocks from the selected profiles' stocks.csv file
        public static void ReadStocksFromProfile(string profileName)
        {
            currentStocks.Clear();
            try
            {
                using (StreamReader sr = new StreamReader($"{getStocksFolderPath(profileName)}/stocks.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        /*
                            0 - Ticker - String
                            1 - Name - String
                            2 - Buying price - Double
                            3 - Quantity - Integer
                            4 - Date bought - DateTime
                        */
                        // Errors are not handled very well for now.
                        try
                        {
                            string[] stockInformation = sr.ReadLine().Split(CSV_DELIMITER);
                            string ticker = stockInformation[0];
                            string name = stockInformation[1];
                            int quantity = int.Parse(stockInformation[2]);
                            double buyingPrice = double.Parse(stockInformation[3]);
                            DateTime dateBought = DateTime.Parse(stockInformation[4]);

                            Stock stock = new Stock(ticker, name, buyingPrice, quantity, dateBought);
                            currentStocks.Add(stock);
                        }
                        catch (Exception ex)
                        {
                            ShowError(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //ShowError("The stocks file wasn't found for the selected profile.");
                ShowError(ex.Message);
            }
        }

        // Shows the error window with an error message as parameter
        public static void ShowError(string errorMessage)
        {
            ErrorWindow window = new ErrorWindow(errorMessage);
            window.Show();
        }
        public static void RunScript(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;
            start.Arguments = args;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
    }
}
