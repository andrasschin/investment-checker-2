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
        // Display
        public static int NUMBER_OF_FRAC_DIGITS = 3;

        // Folder paths
        public static string PROFILES_FOLDER_PATH = "./profiles/";
        public static string GetStocksFolderPath()
        {
            return $"./profiles/{currentProfile}/stocks";
        }
        public static string GetStocksFolderPathForProfile(string profile)
        {
            return $"./profiles/{profile}/stocks";
        }

        // Files
        public static char CSV_DELIMITER = ';';
        public static char PYTHON_OUTPUT_DELIMITER = ';';
        public static int NEXT_STOCK_ID;

        // Python
        static string pyexe = @"C:\Users\Andrew\AppData\Local\Programs\Python\Python38-32\python.exe";
        public static string GET_STOCK_INFO_SCRIPT_PATH = "../../../Scripts/get_stock_info.py";
        public static string GET_STOCK_PRICE_SCRIPT_PATH = "../../../Scripts/get_stock_price.py";


        // GLOBAL VARIABLES

        // Profiles
        public static BindingList<string> profileNames = new BindingList<string>();
        public static string currentProfile;

        // Stocks
        public static List<Stock> currentStocks = new List<Stock>();
        public static bool stocksToBeDeleted = false;

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
                            0 - ID - Integer
                            1 - Ticker - String
                            2 - Name - String
                            3 - Buying price - Double
                            4 - Quantity - Integer
                            5 - Date bought - DateTime
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

        public static string CreateCSVLine(string[] arr)
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
        public static string[] RunScript(string scriptPath, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pyexe;
            start.Arguments = $"{scriptPath} {args}";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            string[] result = new string[2];
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result[0] = reader.ReadLine(); // boolean whether the stock has been found or not
                    result[1] = reader.ReadLine(); // stock information
                }
            }
            return result;
        }
    }
}
