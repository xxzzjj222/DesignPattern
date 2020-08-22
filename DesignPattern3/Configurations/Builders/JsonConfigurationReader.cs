using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Configurations.Builders
{
    public class JsonConfigurationReader : IJsonConfigurationReader
    {
        public Dictionary<string, string> ReadJsonFile(string jsonFilePath)
        {
            Console.WriteLine($"{ jsonFilePath}:获取json本地文件输入流");
            Dictionary<string, string> Data = new Dictionary<string, string>();
            Data.Add("json", "json文件内容");
            return Data;
        }
    }
}
