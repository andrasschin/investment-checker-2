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
    public partial class AddProfileWindow : Form
    {
        public AddProfileWindow()
        {
            InitializeComponent();
        }
        private void AddNewProfile(object sender, EventArgs e)
        {
            string profileName = textInputProfileName.Text;
            string newProfilePath = App.PROFILES_FOLDER_PATH + profileName;
            if (!Directory.Exists(newProfilePath))
            {
                Directory.CreateDirectory(newProfilePath);
                Directory.CreateDirectory(newProfilePath + "/stocks");
                Directory.CreateDirectory(newProfilePath + "/history");
                File.Create(newProfilePath + "/stocks/stocks.csv");
                
                // Add to existing profiles
                App.profileNames.Add(profileName);
                
            } else
            {
                App.ShowError("Profile already exists. Please choose a different name.");
            }

            Close();
        }
        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
    }
}
