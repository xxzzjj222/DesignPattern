using DesignPattern3.Proxy.Example;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern3.Proxy
{
    public class ProxyImage : Image
    {
        private ReadImage readImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }
        public void Display()
        {
            if (readImage==null)
            {
                readImage = new ReadImage(fileName);
            }
            readImage.Display();
        }
    }
}
