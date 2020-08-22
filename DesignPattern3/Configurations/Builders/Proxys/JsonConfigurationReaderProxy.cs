using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPattern3.Configurations.Builders.Proxys
{
    public class JsonConfigurationReaderProxy : IJsonConfigurationReader
    {
        private IJsonConfigurationReader jsonConfigurationReader;

        public JsonConfigurationReaderProxy(IJsonConfigurationReader jsonConfigurationReader)
        {
            this.jsonConfigurationReader = jsonConfigurationReader;
        }

        public Dictionary<string, string> ReadJsonFile(string jsonFilePath)
        {
            RemoteConnection(jsonFilePath);
            return jsonConfigurationReader.ReadJsonFile(jsonFilePath);
        }

        private void RemoteConnection(string jsonFilePath)
        {
            Console.WriteLine($"{jsonFilePath}：进行安全验证");
        }
    }
}
