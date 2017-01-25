using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laoshi.Data
{
    public class Connection
    {
        private static SqlConnection _getConnection;

        public static SqlConnection GetConnection
        {
            get
            {
                if (_getConnection == null)
                {
                    _getConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LaoshiConnection"].ToString());
                }
                return _getConnection;
            }

        }
    }
}
