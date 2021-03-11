using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentChecker2
{
    class Settings
    {
        public Dictionary<string, string> settings;

        public bool AutoUpdate
        {
            get { 
                return bool.Parse(settings["autoUpdate"]); 
            }
            set { 
                settings["autoUpdate"] = value.ToString(); 
            }
        }

        public int AutoUpdateInterval
        {
            get { 
                return int.Parse(settings["autoUpdateInterval"]); 
            }
            set { 
                settings["autoUpdateInterval"] = value.ToString(); 
            }
        }

        public string PythonExeFullPath
        {
            get { 
                return settings["pythonExeFullPath"]; 
            }
            set { 
                settings["pythonExeFullPath"] = value; 
            }
        }

        public Settings(Dictionary<string, string> dict)
        {
            settings = dict;
        }

    }
}
