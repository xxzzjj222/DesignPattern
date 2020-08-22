using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.NullObject.Example
{
    public class MysqlDatabase : AbstractDatabase
    {
        public MysqlDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "mysql数据库url";
        }
    }
}
