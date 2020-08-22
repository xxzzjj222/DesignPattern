using DesignPattern4.NullObject.Example;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.NullObject
{
    public class NullDatabase : AbstractDatabase
    {
        public NullDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "数据库不存在";
        }
    }
}
