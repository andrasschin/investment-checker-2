using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentChecker2
{
    class App
    {
        // Global constants
        public static string PROFILES_FOLDER_PATH = "./profiles/";

        // Global variables
        public static List<string> profileNames = new List<string>();


        // Functions

        // Get profiles from 'stocks' folder, otherwise create the 'profiles' folder
        public static void LoadProfileNames()
        {
            profileNames.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo(App.PROFILES_FOLDER_PATH);
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
