using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Configurations.Builders
{
    public interface IJsonConfigurationReader
    {
        public Dictionary<string, string> ReadJsonFile(string jsonFilePath);
    }
}
