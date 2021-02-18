using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InvestmentChecker2
{
    public partial class MainWindow : Form
    {
        // Constants
        int STOCK_ROW_HEIGHT = 45;
        int STOCK_ROW_LEFT_MARGIN = 5;
        string STOCKS_FOLDER_PATH = "./stocks";

        // Python
        string pyfile = "./scripts/script.py";
        string pyexe = @"C:\Users\Andrew\AppData\Local\Programs\Python\Python38-32\python.exe";

        // App data
        string[] profileNames;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowLoad(object sender, EventArgs e)
        {
            // Get profiles from 'stocks' folder
            DirectoryInfo di = new DirectoryInfo(STOCKS_FOLDER_PATH);
            var res = di.EnumerateDirectories("*").ToArray();
            profileNames = new string[res.Length];
            for (int i = 0; i < res.Length; i++)
            {
                profileNames[i] = res[i].Name;
            }

            //Close();
        }

        /*
        private void RunScript(string cmd, string args)
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
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Open new windows
        private void OpenAddProfileWindow(object sender, EventArgs e)
        {
            AddProfileWindow window = new AddProfileWindow();
            window.Show();
        }

        private void openSearchStockWindow(object sender, EventArgs e)
        {
            SearchStockWindow window = new SearchStockWindow();
            window.Show();
        }

        private void OpenSettingsWindow(object sender, EventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
        }
    }
}
