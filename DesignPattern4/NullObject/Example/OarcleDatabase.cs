using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.NullObject.Example
{
    public class OarcleDatabase : AbstractDatabase
    {
        public OarcleDatabase(string name)
        {
            this.DatabaseName = name;
        }
        public override string GetURL()
        {
            return "Oarcle数据库url";
        }
    }
}
