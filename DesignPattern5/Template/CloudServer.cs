using DesignPattern5.Template.Example;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern5.Template
{
    public abstract class CloudServer
    {
        public void SaveCloudServer(LogFile logFile)
        {
            OpenFile();
            Connection();
            Serialize();
            Transport();
        }

        public abstract void OpenFile();

        public abstract void Connection();

        public abstract void Serialize();

        public abstract void Transport();
    }
}
