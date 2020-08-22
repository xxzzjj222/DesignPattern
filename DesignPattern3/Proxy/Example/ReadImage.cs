using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Proxy.Example
{
    public class ReadImage : Image
    {
        private string fileName;
        private string fileContent;

        public ReadImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }
        public void Display()
        {
            Console.WriteLine("显示: " + fileContent);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("加载: " + fileName);
            fileContent = "图片加载完成";
        }
    }
}
