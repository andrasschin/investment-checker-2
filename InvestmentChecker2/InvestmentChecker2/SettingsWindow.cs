using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    public partial class SettingsWindow : Form
    {
        Color wrongInput = Color.FromArgb(255, 180, 60, 45);
        Color correctInput = Color.FromArgb(255, 232, 232, 232);
        public SettingsWindow()
        {
            InitializeComponent();
            checkBoxAutoUpdate.Checked = App.settings.AutoUpdate;
            textInputAutoUpdateInterval.Enabled = checkBoxAutoUpdate.Checked ? true : false;
            textInputAutoUpdateInterval.Text = App.settings.AutoUpdateInterval.ToString();
            textInputPythonExeFullPath.Text = App.settings.PythonExeFullPath;

            // Icons
            btnBrowse.Text = "\uED25";
        }

        private void checkBoxAutoUpdateOnCheckedChanged(object sender, EventArgs e)
        {
            textInputAutoUpdateInterval.Enabled = checkBoxAutoUpdate.Checked ? true : false;
        }

        private void OpenFileBrowser(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Executable files (*.exe)|*.exe";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textInputPythonExeFullPath.Text = ofd.FileName;
            }
        }

        private bool CheckPythonPath()
        {
            string res = App.RunScript(App.PYTHON_EXE_TEST_SCRIPT_PATH, "");
            return res == "OK" ? true : false;
        }

        private void ValidateAutoUpdateInterval(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[1-9][0-9]*$");
            if (checkBoxAutoUpdate.Checked && !regex.IsMatch(textInputAutoUpdateInterval.Text))
            {
                App.ShowError("Auto update interval has to be a whole number above 0.");
                textInputAutoUpdateInterval.BackColor = wrongInput;
                e.Cancel = true;
            } else
            {
                textInputAutoUpdateInterval.BackColor = correctInput;
            }
        }

        private void ValidatePythonExeFullPath(object sender, CancelEventArgs e)
        {
            // Python executable
            App.settings.PythonExeFullPath = textInputPythonExeFullPath.Text;
            if (!CheckPythonPath())
            {
                App.settings.PythonExeFullPath = "";
                textInputPythonExeFullPath.BackColor = wrongInput;
                e.Cancel = true;
            } else
            {
                textInputPythonExeFullPath.BackColor = correctInput;
            }
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            App.settings.AutoUpdate = checkBoxAutoUpdate.Checked;
            App.settings.AutoUpdateInterval = int.Parse(textInputAutoUpdateInterval.Text);
            App.settings.PythonExeFullPath = textInputPythonExeFullPath.Text;
            App.UpdateSettings();
        }
    }
}
