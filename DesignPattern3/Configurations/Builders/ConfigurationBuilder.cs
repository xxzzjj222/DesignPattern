using DesignPattern3.Configurations.Builders.Decorators;
using DesignPattern3.Configurations.Builders.Proxys;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Configurations.Builders
{
    public class ConfigurationBuilder
    {
        private Configuration configuration = new Configuration();

        public ConfigurationBuilder AddJsonFile(string jsonFilePath,string reload="")
        {
            IJsonConfigurationReader jsonConfigurationReader = new JsonConfigurationReader();

            //jsonConfigurationReader = new JsonConfigurationReaderProxy(jsonConfigurationReader);

            jsonConfigurationReader = new SortJsonConfigurationReaderProxy(jsonConfigurationReader);

            var data=jsonConfigurationReader.ReadJsonFile(jsonFilePath);
            foreach (var item in data)
            {
                configuration.Data.Add(item.Key, item.Value);
            }
            return this;
        }

        public ConfigurationBuilder AddXmlFile(string xmlFilePath)
        {
            Console.WriteLine($"{ xmlFilePath}:获取XML本地文件输入流");
            configuration.Data.Add("xml", "xml文件内容");
            return this;
        }

        public ConfigurationBuilder AddIniFile(string iniFilePath)
        {
            return this;
        }

        public Configuration Build()
        {
            return configuration;
        }
    }
}
