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
        public static string GetStocksFolderPath()
        {
            return $"./profiles/{currentProfile}/stocks";
        }

        // Files
        public static char CSV_DELIMITER = ';';


        // GLOBAL VARIABLES

        // Profiles
        public static BindingList<string> profileNames = new BindingList<string>();
        public static string currentProfile;

        // Stocks
        public static List<Stock> currentStocks = new List<Stock>();
        public static List<int> stocksToBeDeleted = new List<int>();

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
        public static void ReadStocksFromProfile()
        {
            currentStocks.Clear();
            try
            {
                using (StreamReader sr = new StreamReader($"{GetStocksFolderPath()}/stocks.csv"))
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
                        // TODO: Better error handling
                        try
                        {
                            string[] stockInformation = sr.ReadLine().Split(CSV_DELIMITER);
                            int id = int.Parse(stockInformation[0]);
                            string ticker = stockInformation[1];
                            string name = stockInformation[2];
                            int quantity = int.Parse(stockInformation[3]);
                            double buyingPrice = double.Parse(stockInformation[4]);
                            DateTime dateBought = DateTime.Parse(stockInformation[5]);

                            Stock stock = new Stock(id, ticker, name, buyingPrice, quantity, dateBought);
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

        // Rewrites the current profile's stocks.csv, exluding the stocks which were scheduled for deletion
        public static void UpdateStocksCSV()
        {
            using (StreamWriter sr = new StreamWriter($"{GetStocksFolderPath()}/stocks.csv"))
            {
                foreach (Stock stock in currentStocks)
                {
                    sr.WriteLine(CreateCSVLine(stock.GetOutputArray()));
                }
            }
        }

        static string CreateCSVLine(string[] arr)
        {
            string line = "";
            foreach (string item in arr)
            {
                line += $"{item}{CSV_DELIMITER}";
            }
            line.Remove(line.Length - 1); // Remove extra delimiter

            return line;
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
