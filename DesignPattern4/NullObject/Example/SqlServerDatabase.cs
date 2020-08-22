using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.NullObject.Example
{
    public class SqlServerDatabase : AbstractDatabase
    {
        public SqlServerDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "sqlserver数据库url";
        }
    }
}
