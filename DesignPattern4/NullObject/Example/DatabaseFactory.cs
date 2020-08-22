using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern4.NullObject.Example
{
    public class DatabaseFactory
    {
        public static string[] names = { "mysql", "sqlserver", "oarcle" };

        public static AbstractDatabase GetDatabase(string name)
        {
            if (names[0].Equals(name))
            {
                return new MysqlDatabase(name);
            }
            else if (names[1].Equals(name))
            {
                return new SqlServerDatabase(name);
            }
            else if (names[2].Equals(name))
            {
                return new OarcleDatabase(name);
            }
            else
            {
                return new NullDatabase("Null");
            }
        }
    }
}
