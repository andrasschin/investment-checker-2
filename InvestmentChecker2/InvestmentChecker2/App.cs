using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        public static int NUMBER_OF_FRAC_DIGITS = 2;
        public static string NUMBER_DISPLAY_FORMAT = "#,##0.##";

        // Colors
        public static Color inProfit = Color.FromArgb(255, 53, 255, 205);
        public static Color inLoss = Color.FromArgb(255, 255, 73, 92);

        // Folder paths
        public static string PROFILES_FOLDER_PATH = "./profiles/";
        public static string GetStocksFolderPath()
        {
            return $"{PROFILES_FOLDER_PATH}{currentProfile}/stocks";
        }
        public static string GetStocksFolderPathForProfile(string profile)
        {
            return $"{PROFILES_FOLDER_PATH}{profile}/stocks";
        }
        public static string GetCurrencyExchangesFolderPath()
        {
            return $"{PROFILES_FOLDER_PATH}{currentProfile}/currency-exchanges";
        }

        // File information
        public static char CSV_DELIMITER = ';';
        public static char PYTHON_OUTPUT_DELIMITER = ';';
        public static int NEXT_STOCK_ID;
        public static int NEXT_CURRENCY_EXCHANGE_ID;
        
        // File paths
        static string pyexe = "C:/Users/Andrew/AppData/Local/Programs/Python/Python38-32/python.exe";
        public static string STOCK_INFO_SCRIPT_PATH = "../../../Scripts/get_stock_info.py";
        public static string STOCK_PRICE_SCRIPT_PATH = "../../../Scripts/get_stock_price.py";
        public static string PYTHON_EXE_TEST_SCRIPT_PATH = "../../../Scripts/tests/python_test.py";
        public static string SETTINGS_PATH = "./settings/settings.txt";


        // GLOBAL VARIABLES

        // Profiles
        public static BindingList<string> profileNames = new BindingList<string>();
        public static string currentProfile;
        public static string currentProfileMainCurrency = "HUF";

        // Stocks
        public static List<Stock> currentStocks = new List<Stock>();
        public static List<CurrencyExchange> currentCurrencyExchanges = new List<CurrencyExchange>();
        public static bool stocksToBeDeleted = false;
        public static bool currencyExchangeToBeDeleted = false;

        // Settings
        public static Settings settings;

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
        public static void ReadStocksForProfile()
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
                            3 - Quantity - Integer
                            4 - Buying price - Double
                            5 - Currency - String
                            6 - Date bought - DateTime
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
                            string currency = stockInformation[5];
                            DateTime dateBought = DateTime.Parse(stockInformation[6]);

                            Stock stock = new Stock(id, ticker, name, buyingPrice, quantity, currency, dateBought);
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
        public static void GetCurrentPricesForCurrentStocks()
        {
            // Are there order issues?
            string[] tickers = currentStocks.Select(stock => stock.ticker).ToArray();
            string[] res = RunScript(STOCK_PRICE_SCRIPT_PATH, string.Join(" ", tickers)).Split();
            for (int i = 0; i < tickers.Length; i++)
            {
                currentStocks[i].CurrentPrice = double.Parse(res[i], CultureInfo.InvariantCulture);
            }
        }
        public static void ReadCurrencyExchangesForProfile()
        {
            currentCurrencyExchanges.Clear();
            using (StreamReader sr = new StreamReader($"{GetCurrencyExchangesFolderPath()}/currency-exchanges.csv"))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        /*
                            0 - ID - Integer
                            1 - Currency from - String
                            2 - Currency to - String
                            3 - Quantity - Integer
                            4 - Buying price - Double
                            5 - Date bought - DateTime
                         */
                        string[] currencyExchangeInformation = sr.ReadLine().Split(CSV_DELIMITER);
                        int id = int.Parse(currencyExchangeInformation[0]);
                        string currencyFrom = currencyExchangeInformation[1];
                        string currencyTo = currencyExchangeInformation[2];
                        int quantity = int.Parse(currencyExchangeInformation[3]);
                        double buyingPrice = double.Parse(currencyExchangeInformation[4]);
                        DateTime dateBought = DateTime.Parse(currencyExchangeInformation[5]);

                        CurrencyExchange ce = new CurrencyExchange(id, currencyFrom, currencyTo, quantity, buyingPrice, dateBought);
                        currentCurrencyExchanges.Add(ce);
                    }
                    catch (Exception ex)
                    {
                        ShowError(ex.Message);
                    }
                }
            }
        }

        public static void ReadSettings()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(SETTINGS_PATH))
            {
                while (!sr.EndOfStream)
                {
                    string[] option = sr.ReadLine().Split('=');
                    string key = option[0];
                    string value = option[1];
                    dict.Add(key, value);
                }
            }
            Settings newSettings = new Settings(dict);
            settings = newSettings;
        }

        // Rewrites the current profile's stocks.csv, exluding the stocks which were scheduled for deletion
        public static void UpdateStocksCSV()
        {
            using (StreamWriter sw = new StreamWriter($"{GetStocksFolderPath()}/stocks.csv"))
            {
                foreach (Stock stock in currentStocks)
                {
                    sw.WriteLine(CreateCSVLine(stock.GetOutputArray()));
                }
                stocksToBeDeleted = false;
            }
        }

        public static void UpdateCurrencyExchangesCSV()
        {
            using (StreamWriter sw = new StreamWriter($"{GetCurrencyExchangesFolderPath()}/currency-exchanges.csv"))
            {
                foreach (CurrencyExchange ce in currentCurrencyExchanges)
                {
                    sw.WriteLine(CreateCSVLine(ce.GetOutputArray()));
                }
            }
        }

        public static void UpdateSettings()
        {
            using (StreamWriter sw = new StreamWriter(SETTINGS_PATH))
            {
                foreach (KeyValuePair<string, string> setting in settings.settings)
                {
                    sw.WriteLine($"{setting.Key}={setting.Value}");
                }
            }
        }

        public static void CreateDefaultSettings()
        {
            Directory.CreateDirectory("./settings");
            File.Create(SETTINGS_PATH).Close();

            using (StreamWriter sw = new StreamWriter(SETTINGS_PATH))
            {
                sw.Write(
                    "autoUpdate=False\n" +
                    "autoUpdateInterval=0\n" +
                    "pythonExeFullPath="
                    );
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

        public static double GetPercent(double initial, double current)
        {
            return ((current / initial) - 1) * 100;
        }


        // Shows the error window with an error message as parameter
        public static void ShowError(string errorMessage)
        {
            ErrorWindow window = new ErrorWindow(errorMessage);
            window.Show();
        }

        public static string RunScript(string scriptPath, string args)
        {
            string result = "";

            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = settings.PythonExeFullPath;
            start.Arguments = $"{scriptPath} {args}";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            start.CreateNoWindow = true;
            try
            {
                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadLine();
                    }
                }
                return result;
            }
            catch
            {
                App.ShowError("Invalid python executable.");
                return "";
            }
        }

        public static void Log(string callerFunction, string logText)
        {
            string today = DateTime.Today.ToShortDateString();
            string filename = $"log_{callerFunction}_{today}";
            File.Create($"logs/{filename}.txt").Close();
            using (StreamWriter sw = new StreamWriter($"logs/{filename}.txt"))
            {
                sw.Write(logText);
            }
        }
    }
}
