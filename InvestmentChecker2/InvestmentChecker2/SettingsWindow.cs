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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
            checkBoxAutoUpdate.Checked = App.settings.AutoUpdate;
            textInputAutoUpdateInterval.Enabled = checkBoxAutoUpdate.Checked ? true : false;
            textInputAutoUpdateInterval.Text = App.settings.AutoUpdateInterval.ToString();
            textInputPythonExeFullPath.Text = App.settings.PythonExeFullPath;
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            App.settings.AutoUpdate = checkBoxAutoUpdate.Checked;
            App.settings.AutoUpdateInterval = int.Parse(textInputAutoUpdateInterval.Text);
            App.settings.PythonExeFullPath = textInputPythonExeFullPath.Text;
            App.UpdateSettings();
            Close();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxAutoUpdateOnCheckedChanged(object sender, EventArgs e)
        {
            textInputAutoUpdateInterval.Enabled = checkBoxAutoUpdate.Checked ? true : false;
        }
    }
}
