using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Configurations
{
    public class Configuration
    {
        public Dictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        // 1、扩展思路
        //  public List<IConfigurationProvider> lists = new List<IConfigurationProvider>();
        public void Set(string key,string value)
        {
            Data.Add(key, value);
        }

        public string this[string key]
        {
            get
            {
                return Data[key];
            }
        }
    }
}
