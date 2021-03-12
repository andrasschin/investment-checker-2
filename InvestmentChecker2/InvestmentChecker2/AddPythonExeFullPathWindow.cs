using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentChecker2
{
    public partial class AddPythonExeFullPathWindow : Form
    {
        string path;
        public AddPythonExeFullPathWindow()
        {
            InitializeComponent();
            btnBrowse.Text = "\uED25";
        }

        private void OpenFileBrowser(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Executable files (*.exe)|*.exe";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                textInputPath.Text = path;
            }
        }

        private bool CheckPythonPath()
        {
            string res = App.RunScript(App.PYTHON_EXE_TEST_SCRIPT_PATH, "");
            return res == "OK" ? true : false;
        }

        private void ValidatePythonExe(object sender, CancelEventArgs e)
        {
            App.settings.PythonExeFullPath = path;
            if (CheckPythonPath())
            {
                App.UpdateSettings();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
