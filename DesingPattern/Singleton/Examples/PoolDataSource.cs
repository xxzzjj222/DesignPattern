using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPattern6.Singleton.Examples
{
    class PoolDataSource
    {
        private static PoolDataSource poolDataSource = new PoolDataSource();

        private IList<Connection> connections = new List<Connection>();

        private PoolDataSource()
        {
            for (int i = 0; i < 6; i++)
            {
                connections.Add(new Connection());
            }
        }

        public static PoolDataSource GetInstance()
        {
            return poolDataSource;
        }

        public Connection GetConnection()
        {
            return connections[0];
        }
    }
}
