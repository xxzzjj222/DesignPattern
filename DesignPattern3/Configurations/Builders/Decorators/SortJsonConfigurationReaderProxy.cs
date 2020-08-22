using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern3.Configurations.Builders.Decorators
{
    public class SortJsonConfigurationReaderProxy : IJsonConfigurationReader
    {
        private IJsonConfigurationReader jsonConfigurationReader;

        public SortJsonConfigurationReaderProxy(IJsonConfigurationReader jsonConfigurationReader)
        {
            this.jsonConfigurationReader = jsonConfigurationReader;
        }
        public Dictionary<string, string> ReadJsonFile(string jsonFilePath)
        {
            var data=jsonConfigurationReader.ReadJsonFile(jsonFilePath);
            SortData(data);
            return data;
        }

        public void SortData(IDictionary<string,string> data)
        {
            Console.WriteLine("json配置文件数据排序");
        }
    }
}
