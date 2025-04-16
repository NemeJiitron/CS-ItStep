using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.HM_16
{
    internal class AppConfig
    {
        private static AppConfig instance = null;
        private Dictionary<string, string> _config;
        public AppConfig()
        {
            _config = new Dictionary<string, string>();
        }
        public static AppConfig Instance()
        {
            if (instance == null)
            {
                instance = new AppConfig();
            }
            return instance;
        }
        public void SetSettings(string key, string value)
        {
            _config.Add(key, value);
        }
        public string GetSettings(string key)
        {
            return _config[key];
        }
    }
}
